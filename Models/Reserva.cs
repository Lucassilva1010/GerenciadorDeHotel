using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorHotel.Models
{
    class Reserva
    {
        public Reserva(int diasReserva)
        {
            DiasReserva = diasReserva;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReserva { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes, int capacidade)
        {


            if (hospedes.Count <= capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine($"Erro: O total de hospedes é maior que a quantidade suportada pela Suite: {Suite.TipoSuite} ");

            }








        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuatidadeHospedes()
        {
            int numero = 0;
            try
            {

                for (int i = 0; i < Hospedes.Count; i++)
                {
                    numero++;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine($"Não foi possivel mostrar o total de Hospedes!");
            }
            return numero;

        }

        public decimal CalcularValorDiaria()
        {
            return 0.0m;
        }
    }
}
