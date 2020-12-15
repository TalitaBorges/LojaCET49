﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LojaCET49.Dados.Entidades
{
    public class Produto
    {
        public int Id { get; set; }


        public string Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Preco { get; set; }

        [Display(Name = "Image")]
        public string UrlDaImage { get; set; }

        [Display(Name = "Última Compra")]
        public DateTime UltimaCompra { get; set; }

        [Display(Name = "Última Venda")]
        public DateTime UltimaVenda { get; set; }

        [Display(Name = "Disponível")]
        public bool Disponivel { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }





    }
}