using System;
using System.ComponentModel.DataAnnotations;

namespace Basquete.Models
{
    public class Ponto
    {
        [Key]
        public int JogoID { get; set; }

        public int PontoTimeA { get; set; }

        public int PontoTimeB { get; set; }

        public DateTime DataPartida { get; set; }

        public int Resultado { get; set; }
    }
}
