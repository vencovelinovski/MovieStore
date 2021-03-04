using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieStore.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        public string DirectorName { get; set; }

        public string DirectroId { get; set; }

        public Director Director { get; set; }

        [StringLength(150)]
        public string ProdusentName { get; set; }
        public string ProdusentId { get; set; }
        public Produsent Produsent { get; set; }

        [StringLength(200)]
        public string CategoryName { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

        public string ActorName{ get; set; }

        public string ActorId { get; set; }

        public Actor Actor { get; set; }

        public string Language { get; set; }

        public DateTime RealiseDate { get; set; }


    }
}
