using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zpnet.Models
{

    [Table("Rentals")]
    public class Rental
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Indeks { get; set; }
        [Display(Name = "Produkcja")]
        public string? Produkcja { get; set; }

        public string? Cena { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data rozpoczecia")]
        public DateTime? Data_r { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data zakonczenia")]
        public DateTime? Data_z { get; set; }
        public int? ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client? Client { get; set; }


    }
}
