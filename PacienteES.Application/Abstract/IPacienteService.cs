using PacienteES.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacienteES.Application.Abstract
{
    public interface IPacienteService
    {
        void Create(Paciente paciente);
    }
}
