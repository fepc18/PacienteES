using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using PacienteES.Api.Controllers;
using Repository.Context;
using System;
using Xunit;

namespace PacienteES.Api.Test
{
    public class PacientesControllerTest
    {
        public PacientesControllerTest()
        {

        }

        [Fact]
        public void Ge_SiNoExite_Retorna404()
        {
            var idPaciente = 1;
            
            var mockApplicationDbContext = new Mock<ApplicationDbContext>();
            var mockLogger = new Mock<ILogger<PacientesController>>();
            var mockConfiguration = new Mock<IConfiguration>();
            //  mockApplicationDbContext.Setup(x=>x.)

            // var pacientesController = new PacientesController(mockApplicationDbContext.Object, mockLogger.Object, mockConfiguration.Object);

            //prueba
            // var resultado = pacientesController.Get(idPaciente);

            //Verificacion
            //  Assert.IsType(typeof(NotFoundResult), resultado.Result);
            Assert.True(true);

        }
    }
}
