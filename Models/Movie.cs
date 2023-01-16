using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zpnet.Models
{

    [Table("Movies")]
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Indeks { get; set; }
        [Display(Name ="Tytul")]
        public string? Tytul { get; set; }

        [Display(Name = "Czas trwania")]
        public string? Czas_t { get; set; }
        public string? Rezyser { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Data premiery")]
        public DateTime? Data_p { get; set; }
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }


    }
}
