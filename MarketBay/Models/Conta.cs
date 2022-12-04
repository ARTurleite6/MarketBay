using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketBay.Models
{
    [Table("Conta")]
    public class Conta
    {

        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(9)]
        public string NumeroTelemovel { get; set; }
        public Morada? Morada { get; set; }
    }
}

