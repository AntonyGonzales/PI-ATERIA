
using System.ComponentModel.DataAnnotations;

namespace PracticaN2.Models
{
    public class Contacto
    {
       
        public int id{get;set;}

       
       [Required]
        public string Nombre{get;set;}

        
        public string Apellido{get;set;}

        public string Motivo{get;set;}

        [Required]
        public string Mensaje{get;set;}
    }
}