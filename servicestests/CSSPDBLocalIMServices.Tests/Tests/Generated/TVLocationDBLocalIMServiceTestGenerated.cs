/* Auto generated from C:\CSSPTools\src\codegen\_package\netcoreapp3.1\ServicesClassNameServiceTestGenerated.exe
 *
 * Do not edit this file.
 *
 */

using CSSPEnums;
using CSSPModels;
using CSSPCultureServices.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Xunit;
using System.ComponentModel.DataAnnotations;
using CSSPCultureServices.Resources;
using LocalServices;

namespace CSSPDBLocalIMServices.Tests
{
    public partial class TVLocationDBLocalIMServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        #endregion Properties

        #region Constructors
        public TVLocationDBLocalIMServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Functions private
        private void CheckTVLocationFields(List<TVLocation> tvLocationList)
        {
            Assert.False(string.IsNullOrWhiteSpace(tvLocationList[0].TVText));
            if (!string.IsNullOrWhiteSpace(tvLocationList[0].TVTypeText))
            {
                Assert.False(string.IsNullOrWhiteSpace(tvLocationList[0].TVTypeText));
            }
            if (!string.IsNullOrWhiteSpace(tvLocationList[0].SubTVTypeText))
            {
                Assert.False(string.IsNullOrWhiteSpace(tvLocationList[0].SubTVTypeText));
            }
        }

        #endregion Functions private
    }
}
