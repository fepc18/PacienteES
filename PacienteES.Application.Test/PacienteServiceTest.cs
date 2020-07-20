using Application.Abstract;
using Domain.Entities;
using Domain.ValueObject;
using Moq;
using Application.Implements;
using Repository.Repositories;
using System;
using UnitOfWork;
using Xunit;
using Moq.Language;
using ExpectedObjects;
using System.Collections.Generic;
using Domain.Abstracts;
using System.Linq;

namespace PacienteES.Application.Test
{
    public class PacienteServiceTest
    {
       private Mock<IPacienteRepository> _mockRepository;
       // private Mock<IGenericRepository<Paciente>> _mockRepository;
        private IPacienteService _service;
        private Mock<IUnitOfWork> _mockUnitWork;
        public PacienteServiceTest()
        {
             _mockRepository = new Mock<IPacienteRepository>();
            //_mockRepository = new Mock<IGenericRepository<Paciente>>();
            _mockUnitWork = new Mock<IUnitOfWork>();
           
        }

        [Fact]
        public void Paciente_Get_All()
        {
            //Arrange
            // _mockRepository.Setup(x => x.GetAll()).Returns(listCountry);
            //  var _mock = new Mock<IGenericRepository<Paciente>>();
            var listado = FakeListadoPacientes();
            //_mockUnitWork.Setup(x=>x.Repository= )
            _ = _mockRepository.Setup(x => x.GetAll(null,null,null,null)).Returns(listado.ToList());
            //Act
            _service = new PacienteService(_mockUnitWork.Object, _mockRepository.Object);
            var results = _service.GetAll().ToList();

            //Assert
            Assert.Equal(listado,results);
            Assert.Equal(4, results.Count);
        }
       
        private List<Paciente> FakeListadoPacientes()
        {
            var listPacientes = new List<Paciente>();
            listPacientes.Add(new Paciente() { TipoId = "CC", Identificacion = "27053258", PrimerNombre = "Felipe", PrimerApellido = "Pabon", Zona = "R", EstadoCivilId = 1, EscolaridadId = 2, RegimenId = 1, NivelId = 1, TipoAfiliadoId = "C", EtniaId = 1 });
            listPacientes.Add(new Paciente() { TipoId = "CE", Identificacion = "1085263418", PrimerNombre = "Felipe", PrimerApellido = "Pabon", Zona = "R", EstadoCivilId = 1, EscolaridadId = 2, RegimenId = 1, NivelId = 1, TipoAfiliadoId = "C", EtniaId = 1 });
            listPacientes.Add(new Paciente() { TipoId = "TI", Identificacion = "53105874", PrimerNombre = "Felipe", PrimerApellido = "Pabon", Zona = "R", EstadoCivilId = 1, EscolaridadId = 2, RegimenId = 1, NivelId = 1, TipoAfiliadoId = "C", EtniaId = 1 });
            listPacientes.Add(new Paciente() { TipoId = "CC", Identificacion = "29358741", PrimerNombre = "Felipe", PrimerApellido = "Pabon", Zona = "R", EstadoCivilId = 1, EscolaridadId = 2, RegimenId = 1, NivelId = 1, TipoAfiliadoId = "C", EtniaId = 1 });
            return listPacientes;
        }



    }
}
