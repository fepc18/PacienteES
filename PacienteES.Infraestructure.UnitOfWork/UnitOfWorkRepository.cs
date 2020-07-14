using Repository.Context;
using Repository.Repositories;


namespace UnitOfWork
{
    public interface IUnitOfWorkRepository
    {
        IPacienteRepository PacienteRepository { get; }
    }

    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        public IPacienteRepository PacienteRepository { get; }

        public UnitOfWorkRepository(ApplicationDbContext context)
        {
            PacienteRepository = new PacienteRepository(context);
        }
    }
}
