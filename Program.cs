using GerenciadorHotel.Models;
using System;
using System.Collections.Generic;

namespace GerenciadorHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Hotel");
            //Criando uma Lista de pessoas para que sejam cadastradas como Hospedes
            List<Pessoa> Hospedes = new List<Pessoa>();
            //Definiindo uma pessoa
            Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Augusto");
            Pessoa p2 = new Pessoa(nome: "Anastacia", sobrenome: "Sousa");
            Pessoa p3 = new Pessoa(nome: "Antonella", sobrenome: "Silva");


            //Criando os hospedes e adicionando na lista
            Hospedes.Add(p1);
            Hospedes.Add(p2);
            Hospedes.Add(p3);

            //Definindo uma Suite
            Suite suite = new Suite(tipoSuite: "Imperial", capacidade: 2, valorDiaria: 1.000m);

            //Definindo total de dias de reserva
            Reserva reserva = new Reserva(diasReserva: 10);

            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(Hospedes, suite.Capacidade);

            //Exibir a quantidade de hospedes e valor das diarias atravez dos metodos
            if (reserva.ObterQuatidadeHospedes() > 0)
            {
                Console.WriteLine($"Hospedes {reserva.ObterQuatidadeHospedes()}");
                Console.WriteLine($"Valor da Diária {reserva.CalcularValorDiaria()}");

            }


        }
    }
}
