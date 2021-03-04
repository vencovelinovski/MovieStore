using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieStore.Entities
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [StringLength(300)]
        public string Name { get; set; }

        public DateTime YearOfBirth { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        public bool Popularity { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
