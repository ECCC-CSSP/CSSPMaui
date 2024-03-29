﻿using GenerateCodeBaseServices.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCSSPSQLiteServices
{
    public partial class Startup
    {
        private async Task<bool> CreateFillListTableToDelete(FileInfo fiDLL)
        {
            List<string> ListCSSPDBTableList = new List<string>();

            if (!await FillCSSPDBTableList(ListCSSPDBTableList)) return false;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"/* Auto generated from { AppDomain.CurrentDomain.BaseDirectory }{ AppDomain.CurrentDomain.FriendlyName}.exe");
            sb.AppendLine(@" *");
            sb.AppendLine(@" * Do not edit this file.");
            sb.AppendLine(@" *");
            sb.AppendLine(@" */");
            sb.AppendLine(@"");           
            sb.AppendLine(@"using System.Collections.Generic;");
            sb.AppendLine(@"using System.Threading.Tasks;");
            sb.AppendLine(@"");
            sb.AppendLine(@"namespace CSSPSQLiteServices");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    public partial class CSSPSQLiteService : ICSSPSQLiteService");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"        private async Task<bool> FillListTableToDelete(List<string> ListTableToDelete)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            List<string> TableNameList = new List<string>()");
            sb.AppendLine(@"            {");
            foreach (string CSSPDBTableName in ListCSSPDBTableList)
            {
                sb.AppendLine($@"                ""{ CSSPDBTableName }"",");
            }
            sb.AppendLine(@"            };");
            sb.AppendLine(@"");
            sb.AppendLine(@"            foreach (string s in TableNameList)");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                ListTableToDelete.Add(s);");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"");
            sb.AppendLine(@"            return await Task.FromResult(true);");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"    }");
            sb.AppendLine(@"}");

            FileInfo fiOutputGen = new FileInfo(Configuration.GetValue<string>("FillListTableToDelete"));

            using (StreamWriter sw = fiOutputGen.CreateText())
            {
                sw.Write(sb.ToString());
            }

            Console.WriteLine($"Created { fiOutputGen.FullName }");

            return await Task.FromResult(true);
        }
    }
}
