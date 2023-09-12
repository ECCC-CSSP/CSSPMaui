﻿using GenerateCodeBaseHelper;
using GenerateCodeBaseServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCSSPHelperServices_Tests
{
    public partial class Startup
    {
        public async Task<bool> Generate()
        {
            Console.WriteLine("Generate Starting ...");

            FileInfo fiDLL = new FileInfo(Configuration.GetValue<string>("CSSPHelperModels"));

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            List<Type> types = importAssembly.GetTypes().ToList();

            
            foreach (Type type in types)
            {
                StringBuilder sb = new StringBuilder();
                string TypeName = type.Name;

                string TypeNameLower = "";

                if (type.Name.StartsWith("MWQM"))
                {
                    TypeNameLower = $"{ type.Name.Substring(0, 4).ToLower() }{ type.Name.Substring(4) }";
                }
                else if (type.Name.StartsWith("CSSP"))
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

                //if (TypeName != "AppTaskParameter")
                //{
                //    continue;
                //}

                sb.AppendLine($@"/* Auto generated from { AppDomain.CurrentDomain.BaseDirectory }{ AppDomain.CurrentDomain.FriendlyName}.exe");
                sb.AppendLine(@" *");
                sb.AppendLine(@" * Do not edit this file.");
                sb.AppendLine(@" *");
                sb.AppendLine(@" */");
                sb.AppendLine(@"");
                sb.AppendLine(@"using CSSPEnums;");
                sb.AppendLine(@"using CSSPDBModels;");
                sb.AppendLine(@"using CSSPHelperModels;");
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
                sb.AppendLine(@"using System.Threading.Tasks;");
                sb.AppendLine(@"using System.Transactions;");
                sb.AppendLine(@"using Xunit;");
                sb.AppendLine(@"using System.ComponentModel.DataAnnotations;");
                sb.AppendLine(@"using CSSPCultureServices.Resources;");
                sb.AppendLine(@"using CSSPHelperServices.Tests;");
                sb.AppendLine(@"");
                sb.AppendLine($@"namespace CSSPHelperServices.Tests");
                sb.AppendLine(@"{");
                sb.AppendLine(@"    [Collection(""Sequential"")]");
                sb.AppendLine($@"    public partial class { TypeName }ServiceTest : TestHelper");
                sb.AppendLine(@"    {");
                sb.AppendLine(@"        #region Variables");
                sb.AppendLine(@"        #endregion Variables");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Properties");
                sb.AppendLine(@"        private IConfiguration Configuration { get; set; }");
                sb.AppendLine(@"        private IServiceProvider Provider { get; set; }");
                sb.AppendLine(@"        private IServiceCollection Services { get; set; }");
                sb.AppendLine(@"        private ICSSPCultureService CSSPCultureService { get; set; }");
                sb.AppendLine(@"        private IEnums enums { get; set; }");
                sb.AppendLine($@"        private I{ TypeName }Service { TypeName }Service {{ get; set; }}");
                sb.AppendLine(@"        #endregion Properties");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Constructors");
                sb.AppendLine($@"        public { TypeName }ServiceTest() : base()");
                sb.AppendLine(@"        {");
                sb.AppendLine(@"");
                sb.AppendLine(@"        }");
                sb.AppendLine(@"        #endregion Constructors");
                sb.AppendLine(@"");

                if (!await GenerateConstructorsTestCode(TypeName, TypeNameLower, type, sb)) return await Task.FromResult(false);
                if (!await GeneratePropertiesTestCode(TypeName, TypeNameLower, type, sb)) return await Task.FromResult(false);

                //if (!await GenerateBasicTestNotMapped(TypeName, TypeNameLower, sb)) return await Task.FromResult(false);

                sb.AppendLine(@"        #region Functions private");

                if (!await GenerateSetupTestCodeNotMapped(TypeName, TypeNameLower, sb)) return await Task.FromResult(false);
                if (!await GenerateGetFilledRandomClassnameTestCodeNotMapped(type, TypeName, TypeNameLower, sb)) return await Task.FromResult(false);

                //if (!await GenerateCheckClassNameFieldsTestCode(type, types, TypeName, TypeNameLower, sb)) return await Task.FromResult(false);

                sb.AppendLine(@"");
                sb.AppendLine(@"        #endregion Functions private");
                sb.AppendLine(@"    }");
                sb.AppendLine(@"}");

                string FileName = "";
                FileName = "ClassNameDBFile";

                FileInfo fiOutputGen = new FileInfo(Configuration.GetValue<string>(FileName).Replace("{TypeName}", TypeName));
                using (StreamWriter sw2 = fiOutputGen.CreateText())
                {
                    sw2.Write(sb.ToString());
                }

                Console.WriteLine($"Created [{ fiOutputGen.FullName }] ...");
            }

            Console.WriteLine("");
            Console.WriteLine($"Done ...");
            Console.WriteLine("");
            Console.WriteLine("Generate Finished ...");

            return await Task.FromResult(true);
        }
    }
}