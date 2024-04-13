# Gerenciador de Hotel

## Introdução

Este projeto é um simples sistema de gerenciamento de hotel desenvolvido como parte do curso de formação .NET da DIO (Digital Innovation One). O sistema permite cadastrar reservas de suítes, controlar a quantidade de hóspedes e calcular o valor total da reserva.

## Classes e Funcionalidades

### 1. Suite

A classe `Suite` representa uma suíte no hotel. Ela possui as seguintes propriedades:

- `TipoSuite`: Uma string que indica o tipo da suíte (por exemplo, "Imperial", "Luxo", etc.).
- `Capacidade`: Um inteiro que define o número máximo de hóspedes que a suíte pode acomodar.
- `ValorDiaria`: Um decimal que representa o valor da diária da suíte.

### 2. Reserva

A classe `Reserva` é responsável por gerenciar as reservas de suítes. Ela possui os seguintes atributos:

- `Hospedes`: Uma lista de pessoas hospedadas na suíte.
- `Suite`: A suíte reservada.
- `DiasReserva`: O número de dias da reserva.

Além disso, a classe possui os seguintes métodos:

- `CadastrarHospedes`: Recebe uma lista de pessoas e verifica se o número de hóspedes é compatível com a capacidade da suíte. Se for, os hóspedes são cadastrados na reserva.
- `CadastrarSuite`: Recebe uma suíte e a define como a suíte reservada na reserva.
- `ObterQuatidadeHospedes`: Retorna o número de hóspedes cadastrados na reserva.
- `CalcularValorDiaria`: Calcula o valor total da reserva com base no número de dias e no valor da diária da suíte.

### 3. Pessoa

A classe `Pessoa` representa uma pessoa hospedada no hotel. Ela possui as seguintes propriedades:

- `Nome`: O nome da pessoa.
- `Sobrenome`: O sobrenome da pessoa.

## Funcionamento do Programa

O programa principal `Program.cs` simula o processo de reserva de uma suíte no hotel. Ele cria uma lista de pessoas, define uma suíte e uma reserva, cadastra os hóspedes na suíte e calcula o valor total da reserva com base no número de dias e no valor da diária da suíte.

## Instruções de Uso

1. Clone este repositório para sua máquina local.
2. Abra o projeto em seu ambiente de desenvolvimento preferido.
3. Execute o programa `Program.cs` para ver o funcionamento do sistema de gerenciamento de hotel.

## Conclusão

Espero que este projeto seja útil para entender melhor os conceitos de programação em C# e orientação a objetos. Explore o código-fonte e experimente fazer alterações para testar novas funcionalidades. Se tiver alguma dúvida ou sugestão, não hesite em entrar em contato. 🚀
