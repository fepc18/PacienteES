using Application.Abstract;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using PacienteES.Api.Controllers;
using Repository.Context;
using System;
using Xunit;

namespace PacienteES.Api.Test.Controllers
{
    public class PacientesControllerTests
    {
        private MockRepository mockRepository;

        private Mock<ApplicationDbContext> mockApplicationDbContext;
        private Mock<ILogger<PacientesController>> mockLogger;
        private Mock<IConfiguration> mockConfiguration;
        private Mock<IPacienteService> mockService;

        public PacientesControllerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockApplicationDbContext = this.mockRepository.Create<ApplicationDbContext>();
            this.mockLogger = this.mockRepository.Create<ILogger<PacientesController>>();
            this.mockConfiguration = this.mockRepository.Create<IConfiguration>();
            this.mockService = new Mock<IPacienteService>();
        }

        private PacientesController CreatePacientesController()
        {
            return new PacientesController(
                this.mockLogger.Object,
                this.mockConfiguration.Object, mockService.Object);
        }

        [Fact]
        public void GetCache_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var pacientesController = this.CreatePacientesController();

            // Act
            var result = pacientesController.GetCache();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void GetConfiguration_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var pacientesController = this.CreatePacientesController();

            // Act
            var result = pacientesController.GetConfiguration();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void GetConfigurationEntorno_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var pacientesController = this.CreatePacientesController();

            // Act
            var result = pacientesController.GetConfigurationEntorno();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var pacientesController = this.CreatePacientesController();

            // Act
            var result = pacientesController.Get();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Paged_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var pacientesController = this.CreatePacientesController();
            int page = 0;
            int take = 0;

            // Act
            var result = pacientesController.Paged(
                page,
                take);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var pacientesController = this.CreatePacientesController();
            int id = 0;

            // Act
            var result = pacientesController.Get(
                id);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Post_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var pacientesController = this.CreatePacientesController();
            Paciente paciente = null;

            // Act
            var result = pacientesController.Post(
                paciente);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Put_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var pacientesController = this.CreatePacientesController();
            int id = 0;
            Paciente paciente = null;

            // Act
            var result = pacientesController.Put(
                id,
                paciente);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Delete_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var pacientesController = this.CreatePacientesController();
            int id = 0;

            // Act
            var result = pacientesController.Delete(
                id);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
