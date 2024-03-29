﻿using CSSPDBModels;
using GenerateCodeBaseServices.Services;
using ActionCommandDBServices.Models;
using ActionCommandDBServices.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DBServicesClassNameServiceGeneratedServices.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ValidateAppSettingsServices.Services;
using CSSPCultureServices.Resources;
using ConfigServices.Services;

namespace DBServicesClassNameServiceGeneratedServices.Tests
{
    public class DBServicesClassNameServiceGeneratedServicesTests : ConfigService
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IDBServicesClassNameServiceGeneratedService DBServicesClassNameServiceGeneratedService { get; set; }
        #endregion Properties

        #region Constructors
        public DBServicesClassNameServiceGeneratedServicesTests()
        {
        }
        #endregion Constructors

        #region Functions public
        [Theory]
        [InlineData("en-CA")] // good
        //[InlineData("fr-CA")] // good
        //[InlineData("en-GB")] // good will default to en-CA
        public async Task DBServicesClassNameServiceGeneratedService_Run_Good_Test(string culture)
        {
            Assert.True(await Setup(new CultureInfo(culture), "appsettings.json"));

            Assert.NotNull(Config);
            Assert.NotNull(Services);
            Assert.NotNull(Provider);
            Assert.NotNull(DBServicesClassNameServiceGeneratedService);

            string[] args = new List<string>() { culture }.ToArray();

            Assert.True(await DBServicesClassNameServiceGeneratedService.Run(args));
        }
        [Theory]
        [InlineData("en-CA")] // good
        //[InlineData("fr-CA")] // good
        public async Task DBServicesClassNameServiceGeneratedService_Run_SomeFileMissing_Test(string culture)
        {
            Assert.True(await Setup(new CultureInfo(culture), "appsettings_bad1.json"));

            Assert.NotNull(Config);
            Assert.NotNull(Services);
            Assert.NotNull(Provider);
            Assert.NotNull(DBServicesClassNameServiceGeneratedService);

            string[] args = new List<string>() { culture }.ToArray();

            Assert.False(await DBServicesClassNameServiceGeneratedService.Run(args));
        }
        #endregion Functions public

        #region Functions private
        private async Task<bool> Setup(CultureInfo culture, string appsettingjsonFileName)
        {
            Config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
               .AddJsonFile(appsettingjsonFileName)
               .Build();

            Services = new ServiceCollection();
            Assert.True(await ConfigureBaseServices());

            Assert.True(await ConfigureCSSPDBContext());

            Assert.True(await ConfigureTestDBContext());

            Services.AddSingleton<IDBServicesClassNameServiceGeneratedService, DBServicesClassNameServiceGeneratedService>();

            Assert.True(await BuildServiceProvider());

            DBServicesClassNameServiceGeneratedService = Provider.GetService<IDBServicesClassNameServiceGeneratedService>();
            Assert.NotNull(DBServicesClassNameServiceGeneratedService);

            return await Task.FromResult(true);
        }
        #endregion Functions private
    }

}
