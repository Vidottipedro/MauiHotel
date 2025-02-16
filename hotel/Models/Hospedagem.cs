﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.Models
{
    public class Hospedagem
    {

        public Quarto QuartoSelecionado { get; set; }

        public int QntAdulto { get; set; }  

        public int QntCriancas { get; set; }   

        public DateTime DataCheckin { get; set; }

        public DateTime DataCheckout { get; set;}

        public int Estadia
        {
            get => DataCheckout.Subtract(DataCheckout).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdulto * QuartoSelecionado.ValorDiaraAdulto;
                double valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valor_adultos + valor_criancas) * Estadia;

                return total;

            }
        }

    }
}
