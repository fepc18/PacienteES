using Domain.Entities;
using Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacienteES.Infraestructure.Repository.EntityConfiguration
{
    public class PacienteConfiguration
    {
        public PacienteConfiguration(EntityTypeBuilder<Paciente> entityBuilder)
        {
           /* entityBuilder
               .Property<Zona>("Zona")
               .UsePropertyAccessMode(Microsoft.EntityFrameworkCore.PropertyAccessMode.Field)
               .HasColumnName("Zona")
               .IsRequired();*/
            
        }
    }
}
