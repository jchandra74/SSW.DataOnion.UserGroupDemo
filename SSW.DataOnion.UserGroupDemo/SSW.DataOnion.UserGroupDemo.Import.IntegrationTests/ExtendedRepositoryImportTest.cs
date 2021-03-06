﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSW.Data.Interfaces;
using SSW.DataOnion.UserGroupDemo.DataInterfaces.Repositories;
using SSW.DataOnion.UserGroupDemo.Import.IntegrationTests.Autofac;
using Xunit;

namespace SSW.DataOnion.UserGroupDemo.Import.IntegrationTests
{
    [Collection("DataCollection")]
    public class ExtendedRepositoryImportTest
    {

        private readonly DataFixture _dataFixture;

        public ExtendedRepositoryImportTest(DataFixture dataFixture)
        {
            _dataFixture = dataFixture;
        }

        [Fact]
        public void DoImportTest()
        {
            var studentRepository = _dataFixture.GetDependency<IStudentRepository>();
            var unitOfWork = _dataFixture.GetDependency<IUnitOfWork>();

            // touch the database to initialize
            int c = studentRepository.Get().Count();

            var importer = new ExtendedRepositoryImport(studentRepository);
            importer.Import(new CsvStudentDataSource("App_Data/names.csv"));
        }

    }
}
