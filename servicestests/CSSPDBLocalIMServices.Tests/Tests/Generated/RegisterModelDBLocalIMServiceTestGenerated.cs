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
    public partial class RegisterModelDBLocalIMServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        #endregion Properties

        #region Constructors
        public RegisterModelDBLocalIMServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Functions private
        private void CheckRegisterModelFields(List<RegisterModel> registerModelList)
        {
            Assert.False(string.IsNullOrWhiteSpace(registerModelList[0].FirstName));
            if (!string.IsNullOrWhiteSpace(registerModelList[0].Initial))
            {
                Assert.False(string.IsNullOrWhiteSpace(registerModelList[0].Initial));
            }
            Assert.False(string.IsNullOrWhiteSpace(registerModelList[0].LastName));
            Assert.False(string.IsNullOrWhiteSpace(registerModelList[0].LoginEmail));
            Assert.False(string.IsNullOrWhiteSpace(registerModelList[0].Password));
            Assert.False(string.IsNullOrWhiteSpace(registerModelList[0].ConfirmPassword));
            if (registerModelList[0].ContactTitle != null)
            {
                Assert.NotNull(registerModelList[0].ContactTitle);
            }
        }

        #endregion Functions private
    }
}
