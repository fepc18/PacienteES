using Models;
using Domain.Entities;
using Repository.Context;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public interface IPacienteRepository : IPagedRepository<Paciente>, IReadRepository<Paciente>, ICreateRepository<Paciente>, IRemoveRepository<Paciente>, IUpdateRepository<Paciente>
    {

    }

    public class PacienteRepository : GenericRepository<Paciente>, IPacienteRepository
    {
        public PacienteRepository(
            ApplicationDbContext context
        )
        {
            _context = context;
        }
    }
}
