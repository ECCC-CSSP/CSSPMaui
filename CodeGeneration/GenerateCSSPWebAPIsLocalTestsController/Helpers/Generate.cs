﻿using GenerateCodeBaseHelper;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCSSPWebAPIsLocal_TestsController
{
    public partial class Startup
    {
        public async Task<bool> Generate()
        {
            Console.WriteLine("Generate Starting ...");

            FileInfo fiDLL = new FileInfo(Configuration.GetValue<string>("CSSPDBLocalModels"));

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();

            foreach (Type type in types)
            {
                bool ClassNotMapped = false;
                StringBuilder sb = new StringBuilder();
                string TypeName = type.Name;

                string TypeNameLower = "";

                if (type.Name.StartsWith("MWQM"))
                {
                    TypeNameLower = $"{ type.Name.Substring(0, 4).ToLower() }{ type.Name.Substring(4) }";
                }
                else if (type.Name.StartsWith("TV") || type.Name.StartsWith("VP"))
                {
                    TypeNameLower = $"{ type.Name.Substring(0, 2).ToLower() }{ type.Name.Substring(2) }";
                }
                else
                {
                    TypeNameLower = $"{ type.Name.Substring(0, 1).ToLower() }{ type.Name.Substring(1) }";
                }

                if (GenerateCodeBase.SkipType(type))
                {
                    continue;
                }

                //if (type.Name != "Address")
                //{
                //    continue;
                //}

                foreach (CustomAttributeData customAttributeData in type.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        ClassNotMapped = true;
                        break;
                    }
                }

                if (!ClassNotMapped)
                {
                    sb.AppendLine($@"/* Auto generated from { AppDomain.CurrentDomain.BaseDirectory }{ AppDomain.CurrentDomain.FriendlyName}.exe");
                    sb.AppendLine(@" *");
                    sb.AppendLine(@" * Do not edit this file.");
                    sb.AppendLine(@" *");
                    sb.AppendLine(@" */");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"using CSSPEnums;");
                    sb.AppendLine(@"using CSSPDBModels;");
                    sb.AppendLine(@"using CSSPDBServices;");
                    sb.AppendLine(@"using CSSPWebAPIs.Controllers;");
                    sb.AppendLine(@"using CSSPCultureServices.Services;");
                    sb.AppendLine(@"using Microsoft.AspNetCore.Mvc;");
                    sb.AppendLine(@"using Microsoft.EntityFrameworkCore;");
                    sb.AppendLine(@"using Microsoft.Extensions.Configuration;");
                    sb.AppendLine(@"using Microsoft.Extensions.DependencyInjection;");
                    sb.AppendLine(@"using System;");
                    sb.AppendLine(@"using System.Collections.Generic;");
                    sb.AppendLine(@"using System.Globalization;");
                    sb.AppendLine(@"using System.IO;");
                    sb.AppendLine(@"using System.Linq;");
                    sb.AppendLine(@"using System.Net.Http;");
                    sb.AppendLine(@"using System.Net.Http.Headers;");
                    sb.AppendLine(@"using System.Text.Json;");
                    sb.AppendLine(@"using System.Threading.Tasks;");
                    sb.AppendLine(@"using System.Transactions;");
                    sb.AppendLine(@"using Xunit;");
                    sb.AppendLine(@"using CSSPDBPreferenceServices;");
                    sb.AppendLine(@"using CSSPScrambleServices;");
                    sb.AppendLine(@"using CSSPDBFilesManagementModels;");
                    sb.AppendLine(@"using CSSPDBCommandLogModels;");
                    sb.AppendLine(@"using CSSPDBSearchModels;");
                    sb.AppendLine(@"using LoggedInServices;");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"namespace CSSPWebAPIsLocalControllerTests");
                    sb.AppendLine(@"{");
                    sb.AppendLine($@"    public partial class { TypeName }ControllerTest");
                    sb.AppendLine(@"    {");
                    sb.AppendLine(@"        #region Variables");
                    sb.AppendLine(@"        #endregion Variables");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"        #region Properties");
                    sb.AppendLine(@"        private IConfiguration Configuration { get; set; }");
                    sb.AppendLine(@"        private IServiceProvider Provider { get; set; }");
                    sb.AppendLine(@"        private IServiceCollection Services { get; set; }");
                    sb.AppendLine(@"        private ICSSPCultureService CSSPCultureService { get; set; }");
                    sb.AppendLine(@"        private ILoggedInService LoggedInService { get; set; }");
                    sb.AppendLine($@"        private I{ TypeName }DBService { TypeName }DBService {{ get; set; }}");
                    sb.AppendLine(@"        private string CSSPAzureUrl { get; set; }");
                    sb.AppendLine(@"        private string LocalUrl { get; set; }");
                    sb.AppendLine(@"        private CSSPDBContext db { get; set; }");
                    sb.AppendLine($@"        private I{ TypeName }Controller { TypeName }Controller {{ get; set; }}");
                    if (TypeName == "Contact")
                    {
                        sb.AppendLine(@"        private Contact contact2 { get; set; }");
                    }
                    else
                    {
                    }
                    sb.AppendLine(@"        #endregion Properties");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"        #region Constructors");
                    sb.AppendLine($@"        public { TypeName }ControllerTest()");
                    sb.AppendLine(@"        {");
                    sb.AppendLine(@"        }");
                    sb.AppendLine(@"        #endregion Constructors");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"        #region Functions public");

                    if (!await GenerateControllersContructorGoodTest(TypeName, TypeNameLower, sb)) return await Task.FromResult(false);
                    if (TypeName == "AspNetUser")
                    {

                    }
                    else
                    {
                        if (!await GenerateControllersCRUDGoodTest(TypeName, TypeNameLower, sb)) return await Task.FromResult(false);
                    }
                    sb.AppendLine(@"        #endregion Functions public");

                    sb.AppendLine(@"");
                    sb.AppendLine(@"        #region Functions private");
                    if (!await GenerateControllerSetupPrivateTest(TypeName, TypeNameLower, sb)) return await Task.FromResult(false);
                    sb.AppendLine(@"        #endregion Functions private");

                    sb.AppendLine(@"    }");
                    sb.AppendLine(@"}");

                    string fileName = "TypeNameFile";

                    FileInfo fiOutputGen = new FileInfo(Configuration.GetValue<string>(fileName).Replace("{TypeName}", TypeName));
                    using (StreamWriter sw2 = fiOutputGen.CreateText())
                    {
                        sw2.Write(sb.ToString());
                    }

                    Console.WriteLine($"Created { fiOutputGen.FullName }");
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"Done ...");
            Console.WriteLine("");
            Console.WriteLine("Generate Finished ...");


            return await Task.FromResult(true);
        }
    }
}
