using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieStore.Entities
{
   public class Produsent
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        public DateTime YearOfBirth { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }


    }
}
