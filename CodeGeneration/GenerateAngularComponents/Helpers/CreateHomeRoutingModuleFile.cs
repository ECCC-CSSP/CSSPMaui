﻿using GenerateCodeBaseHelper;
using GenerateCodeBaseServices.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GenerateAngularComponents
{
    public partial class Startup
    {
        private void CreateHomeRoutingModuleFile(int max, List<DLLTypeInfo> DLLTypeInfoCSSPDBModelsList)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"/*");
            sb.AppendLine($@" * Auto generated from { AppDomain.CurrentDomain.BaseDirectory }{ AppDomain.CurrentDomain.FriendlyName}.exe");
            sb.AppendLine(@" *");
            sb.AppendLine(@" * Do not edit this file.");
            sb.AppendLine(@" *");
            sb.AppendLine(@" */");
            sb.AppendLine(@"");

            sb.AppendLine(@"import { NgModule } from '@angular/core';");
            sb.AppendLine(@"import { Routes, RouterModule } from '@angular/router';");
            sb.AppendLine(@"import { HomeComponent } from './home.component';");
            sb.AppendLine(@"import { AuthGuard } from '../../guards';");
            sb.AppendLine(@"");
            sb.AppendLine(@"const routes: Routes = [");
            sb.AppendLine(@"  {");
            sb.AppendLine(@"    path: '', component: HomeComponent, canActivate: [AuthGuard], children: [");

            int count = 0;
            foreach (DLLTypeInfo dllTypeInfoModels in DLLTypeInfoCSSPDBModelsList)
            {
                if (GenerateCodeBase.SkipType(dllTypeInfoModels.Type))
                {
                    continue;
                }

                if (!dllTypeInfoModels.HasNotMappedAttribute)
                {
                    count += 1;
                    if (count > max) break;

                    sb.AppendLine($@"      {{ path: '{ dllTypeInfoModels.Name.ToLower() }', loadChildren: () => import('../../test-components/generated/{ dllTypeInfoModels.Name.ToLower() }/{ dllTypeInfoModels.Name.ToLower() }.module').then(mod => mod.{ dllTypeInfoModels.Name }Module) }},");
                }
            }

            sb.AppendLine(@"    ]");
            sb.AppendLine(@"  }");
            sb.AppendLine(@"];");
            sb.AppendLine(@"");
            sb.AppendLine(@"@NgModule({");
            sb.AppendLine(@"  imports: [RouterModule.forChild(routes)],");
            sb.AppendLine(@"  exports: [RouterModule]");
            sb.AppendLine(@"})");
            sb.AppendLine(@"export class HomeRoutingModule { }");

            FileInfo fiOutputGen = new FileInfo(Configuration.GetValue<string>("HomeRoutingModuleFileName"));
            using (StreamWriter sw2 = fiOutputGen.CreateText())
            {
                sw2.Write(sb.ToString());
                Console.WriteLine($"Created { fiOutputGen.FullName }");
            }
        }
    }
}
