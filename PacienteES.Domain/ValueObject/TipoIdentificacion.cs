using Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.ValueObject
{
    [Owned]
    public class TipoIdentificacion
        : Enumeration
    {
        public static TipoIdentificacion CedulaCiudadania = new TipoIdentificacion("CC", "Cédula de Ciudadania");
        public static TipoIdentificacion CedulaExtranjeria = new TipoIdentificacion("CE", "Cédula de Extranjeria");

        public TipoIdentificacion(string id, string name)
            : base(id, name)
        {
        }
    }
}
