using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaPadaria.Models
{
    internal class Venda
    {
        public int id_venda { get; set; }
        public decimal valor_total { get; set; }
        public DateOnly data_venda { get; set; }
    }
}
