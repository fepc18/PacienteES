using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.ValueObject
{
    [NotMapped]
    public class Genero
        : Enumeration
    {
        public static Genero Masculino = new Genero("M", "Masculino");
        public static Genero Femenino = new Genero("F", "Femenino");

        public Genero(string id, string name)
            : base(id, name)
        {
        }
    }
}
