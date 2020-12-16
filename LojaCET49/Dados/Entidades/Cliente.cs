using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCET49.Dados.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Morada { get; set; }

        public string Telefone { get; set; }

        public string Nif { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Fotografia")]
        public string UrlDaImage { get; set; }

         


    }
}

