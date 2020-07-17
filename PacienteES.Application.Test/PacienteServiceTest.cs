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

namespace PacienteES.Application.Test
{
    public class PacienteServiceTest
    {
        private Mock<IPacienteRepository> _mockRepository;
        private IPacienteService _service;
        private Mock<IUnitOfWork> _mockUnitWork;
        public PacienteServiceTest()
        {
            _mockRepository = new Mock<IPacienteRepository>();
            _mockUnitWork = new Mock<IUnitOfWork>();
            _service = new PacienteService(_mockUnitWork.Object, _mockRepository.Object);
        }

        /* [Fact]
         public void Paciente_Get_All()
         {
             //Arrange
             _mockRepository.Setup(x => x.GetAll()).Returns(listCountry);

             //Act
             List<Country> results = _service.GetAll() as List<Country>;

             //Assert
             Assert.IsNotNull(results);
             Assert.AreEqual(3, results.Count);
         }*/
       


        
    }
}
