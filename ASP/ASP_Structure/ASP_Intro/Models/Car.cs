using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace ASP_Intro.Models
{
    [Table("cars")]
    public class Car
    {
        [Column("car_id")]
        [Key]
        public int VoitureId { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name="Marque de la voiture")]
        public string Marque { get; set; }

        [Required(ErrorMessage = "Le modèle est obligatoire")]
        [MaxLength(30, ErrorMessage = "Le modèle est trop long !")]
        public string Modele { get; set; }

        //[Required]
        //public Engine engine;


        [NotMapped]
        public string Pilote { get; set; }


    }
}
