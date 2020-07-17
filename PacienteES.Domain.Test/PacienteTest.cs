using Domain.Entities;
using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ExpectedObjects;
using FluentAssertions;
namespace PacienteES.Domain.Test
{
    public class PacienteTest
    {

        private Paciente FakePaciente()
        {
            return new Paciente("CC", "123456");
        }
        private Paciente FakePacienteEmptyIdentificacion()
        {
            return new Paciente("CC", string.Empty);
        }
        [Fact]
        public void Constructor_paciente_success_object()
        {
            // Arrange
            Paciente mockPaciente = FakePaciente();
            // Act           
            Paciente paciente = new Paciente(mockPaciente.TipoId, mockPaciente.Identificacion);

            // Assert
            mockPaciente.ToExpectedObject().ShouldMatch(paciente);

        }
        [Fact]
        public void Constructor_paciente_success()
        {
            // Arrange
            Paciente mockPaciente = FakePaciente();
            // Act           
            Paciente paciente = new Paciente(mockPaciente.TipoId, mockPaciente.Identificacion);

            // Assert
            Assert.Equal(mockPaciente.TipoId, paciente.TipoId);
            Assert.Equal(mockPaciente.Identificacion, paciente.Identificacion);

        }
        [Fact]
        public void Handle_throws_exception_when_no_identificacion()
        {
            // Act   
            var MensajeErrorEsperado = "Parametro inválido (Parameter 'identificacion')";
            //    Paciente paciente = FakePacienteEmptyIdentificacion();

            // Assert
            Assert.Throws<ArgumentException>(() => new Paciente(TipoIdentificacion.CedulaCiudadania.Id, string.Empty));
            Assert.Throws<ArgumentException>(() => new Paciente(TipoIdentificacion.CedulaCiudadania.Id, null));
            var MensajeErrorDominio = Assert.Throws<ArgumentException>(() => new Paciente(TipoIdentificacion.CedulaCiudadania.Id, null)).Message;
            Assert.Equal(MensajeErrorEsperado, MensajeErrorDominio);
        }
      

        [Fact]
        public void Throw_Error_Identificacion_Is_Null()
        {
            var MensajeErrorEsperado = "Parametro inválido (Parameter 'identificacion')";
            FluentActions.Invoking(() => new Paciente(TipoIdentificacion.CedulaCiudadania.Id, null)).Should()
                .Throw<ArgumentException>()
                .WithMessage(MensajeErrorEsperado);
        }
    }
}
