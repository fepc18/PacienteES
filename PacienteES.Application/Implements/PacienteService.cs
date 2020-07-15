using PacienteES.Application.Abstract;
using PacienteES.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWork;

namespace PacienteES.Application.Implements
{
    class PacienteService : IPacienteService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PacienteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        /*public void Create(UserExample model)
        {
            // Call to your repository
            _uow.Repository.UserRepository.Add(model);

            // Save changes
            _uow.SaveChanges();
        }*/
    }
}
