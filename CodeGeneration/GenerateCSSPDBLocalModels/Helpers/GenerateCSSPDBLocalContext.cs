﻿using GenerateCodeBaseHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCSSPDBLocalModels
{
    public partial class Startup
    {
        public async Task<bool> GenerateCSSPDBLocalContext()
        {
            Console.WriteLine("Generate Starting ...");

            FileInfo fiDLL = new FileInfo(Config.GetValue<string>("CSSPDBModels"));

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"/*");
            sb.AppendLine($@" * Auto generated from { AppDomain.CurrentDomain.BaseDirectory }{ AppDomain.CurrentDomain.FriendlyName}.exe");
            sb.AppendLine(@" *");
            sb.AppendLine(@" * Do not edit this file.");
            sb.AppendLine(@" *");
            sb.AppendLine(@" */");
            sb.AppendLine(@"");
            sb.AppendLine(@"using Microsoft.EntityFrameworkCore;");
            sb.AppendLine(@"using Microsoft.Extensions.Configuration;");
            sb.AppendLine(@"");
            sb.AppendLine(@"namespace CSSPDBLocalModels");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    public partial class CSSPDBLocalContext : DbContext");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"        #region Properties");

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {

                if (GenerateCodeBase.SkipType(type))
                {
                    continue;
                }

                //if (type.Name == "AppTaskParameter")
                //{
                //    continue;
                //}

                string plurial = "s";

                if (type.Name == "Address")
                {
                    plurial = "es";
                }

                sb.AppendLine($@"        public virtual DbSet<Local{ type.Name }> Local{ type.Name }{ plurial } {{ get; set; }}");
            }

            sb.AppendLine(@"        #endregion Properties");
            sb.AppendLine(@"");
            sb.AppendLine(@"        public CSSPDBLocalContext()");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"");
            sb.AppendLine(@"        public CSSPDBLocalContext(DbContextOptions<CSSPDBLocalContext> options)");
            sb.AppendLine(@"            : base(options)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"");
            sb.AppendLine(@"        #region Overrides");
            sb.AppendLine(@"        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"        protected override void OnModelCreating(ModelBuilder modelBuilder)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            base.OnModelCreating(modelBuilder);");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"        #endregion Overrides");
            sb.AppendLine(@"");
            sb.AppendLine(@"");
            sb.AppendLine(@"    }");
            sb.AppendLine(@"}");

            FileInfo fiOutputGen = new FileInfo(Config.GetValue<string>("CSSPDBLocalContext"));
            using (StreamWriter sw = fiOutputGen.CreateText())
            {
                sw.Write(sb.ToString());
            }
            Console.WriteLine($"Create New { fiOutputGen.FullName }");

            Console.WriteLine("");
            Console.WriteLine($"Done ...");
            Console.WriteLine("");
            Console.WriteLine("Generate Finished ...");

            return await Task.FromResult(true);
        }
    }
}
