using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorHotel.Models
{
    class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReserva { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

        }

        public void CadastrarSuite(Suite suite)
        {

        }

        public int ObterQuatidadeHospedes()
        {
            return 0;
        }

        public decimal CalcularValorDiaria()
        {
            return 0.0m;
        }
    }
}
