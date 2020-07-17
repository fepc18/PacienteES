using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.ValueObject
{
    [NotMapped]
    public class Zona
        : Enumeration
    {
        public static Zona Urbana = new Zona("U", "Urbana");
        public static Zona Rural = new Zona("R", "Rural");

        public Zona(string id, string name)
            : base(id, name)
        {
        }
    }
}
