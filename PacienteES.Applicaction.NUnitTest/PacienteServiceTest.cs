using Application.Abstract;
using Application.Implements;
using Domain.Entities;
using Domain.ValueObject;
using Moq;
using NUnit.Framework;
using Repository.Repositories;
using UnitOfWork;

namespace Applicaction.NUnitTest
{
    [TestFixture]
    public class PacienteServiceTest
    {
         private Mock<IPacienteRepository> _mockRepository;
        private IPacienteService _service;
        private Mock<IUnitOfWork> _mockUnitWork;
        public PacienteServiceTest()
        {
          

        }
        [SetUp]
        public void Initialize()
        {
            _mockRepository = new Mock<IPacienteRepository>();
            _mockUnitWork = new Mock<IUnitOfWork>();
            _service = new PacienteService(_mockUnitWork.Object, _mockRepository.Object);
        }

       /* [Test]
        public void Can_Add_Paciente()
        {
            //Arrange
            int Id = 1;
            Paciente emp = new Paciente(TipoIdentificacion.CedulaCiudadania, "1085263418");

            _mockRepository.Setup(m => m.Add(emp)).ReturnsAsync((Paciente e) =>
            {
                return e;
            });

            //Act
            _service.Create(emp);

            //Assert
            // Assert.sho (Id, emp.Id);
            _mockUnitWork.Verify(m => m.CommitTransaction(), Times.Once);

        }*/
    }
}