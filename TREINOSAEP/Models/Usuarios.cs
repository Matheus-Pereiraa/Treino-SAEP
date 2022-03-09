using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TREINOSAEP.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Perfis")]
        
        public int idPerfil { get; set; }
        public Perfis Perfis { get; set; }

        public string Senha { get; set; }
    }
}
