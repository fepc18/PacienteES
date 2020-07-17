using System;
using System.ComponentModel.DataAnnotations;
using Domain.SeedWork;
using Domain.ValueObject;

namespace Domain.Entities
{
    public class Paciente : Entity
    {
        [Required]
        public string TipoId { get; set; }
        [Required]
        public string Identificacion { get; set; }
        [Required]
        public String PrimerNombre { get; set; }
        public String SegundoNombre { get; set; }
        [Required]
        public String PrimerApellido { get; set; }
        public String SegundoApellido { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Barrio { get; set; }
        [Required]
        public string Zona { get; set; }
        public string Municipio { get; set; }
        
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Genero { get; set; }
        public string LugarExpedicion { get; set; }
        [Required]
        public int EstadoCivilId { get; set; }

        public string Ocupacion { get; set; }
        [Required]
        public int EscolaridadId { get; set; }
        public string Carnet { get; set; }
        [Required]
        public int RegimenId { get; set; }
        [Required]
        public int NivelId { get; set; }
        [Required]
        public string TipoAfiliadoId { get; set; }
        public string TipoSangre { get; set; }
        [Required]
        public int EtniaId { get; set; }
        public Boolean Activo { get; set; }
        public string TipoIdAcompanante { get; set; }
       
        public string IdentificacionAcompanante { get; set; }
       
        public String PrimerNombreAcompanante { get; set; }
        public String SegundoNombreAcompanante { get; set; }
       
        public String PrimerApellidoAcompanante { get; set; }
        public String SegundoApellidoAcompanante { get; set; }
        public string LugarExpedicionAcompanante { get; set; }
        public string GeneroAcompanante { get; set; }
        public DateTime FechaNacimientoAcompanante { get; set; }

        public string DireccionAcompanante { get; set; }
        public string BarrioAcompanante { get; set; }

        public string MunicipioAcompanante { get; set; }
        public string OcupacionAcompanante { get; set; }
        public Paciente()
        {

        }
        public Paciente(string tipoIdentificacion, string identificacion)
        {
            if (string.IsNullOrEmpty(identificacion))
                throw new ArgumentException("Parametro inválido", nameof(identificacion));
            this.TipoId = tipoIdentificacion;
            this.Identificacion = identificacion;
        }

    }
    
   
   
    
   
    
}
