using Domain.Entities;

using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWork;
using Application.Abstract;
using System.Linq;
using Context;

namespace Application.Implements
{
    public class PacienteService : IPacienteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IUnitOfWork unitOfWork, IPacienteRepository pacienteRepository)
        {
            _unitOfWork = unitOfWork;
            _pacienteRepository = pacienteRepository;
        }


        public void Create(Paciente paciente)
        {
            _unitOfWork.Repository.PacienteRepository.Add(paciente);

            _unitOfWork.SaveChanges();
        }

        public void Delete(Paciente paciente)
        {
            _unitOfWork.Repository.PacienteRepository.Remove(paciente);

            _unitOfWork.SaveChanges();
        }

        public Paciente Find(object id)
        {
            return _unitOfWork.Repository.PacienteRepository.FirstOrDefault(x => x.Id == Convert.ToInt32(id));
        }

        public IEnumerable<Paciente> GetAll()
        {
            return _unitOfWork.Repository.PacienteRepository.GetAll();
        }

        public DataCollection<Paciente> Paged(int page, int take)
        {
            return _unitOfWork.Repository.PacienteRepository.GetPaged(
                page: page,
                take: take,
                orderBy: x => x.OrderByDescending(y => y.Id)
            );
        }

        public void Update(Paciente paciente)
        {
            _unitOfWork.Repository.PacienteRepository.Update(paciente);

            _unitOfWork.SaveChanges();
        }
    }
}
