# EXERCICIOS POO COM MANIPULAÇÃO DE ARRAYS

## 1) Sistema de Reserva de Hotel em C#

### Regras de Negócio:

1. Neste exemplo, utilizaremos as classes Pessoa, Suíte e Reserva para representar o hóspede, a suíte e a reserva, respectivamente.

   i) A Classe PESSOA deverá ter obrigatoriamente os seguintes atributos, mas sinta-se livre para incluir outros que preferir:
      (1) Nome
      (2) Idade
      (3) Gênero
      (4) Profissão

   ii) A Classe SUITE deverá ter obrigatoriamente e no mínimo, os atributos abaixo:
      (1) Capacidade
      (2) Valor da Diária

   iii) A classe RESERVA deverá ter obrigatoriamente e no mínimo, os atributos abaixo:
      (1) PESSOA
      (2) SUITE
      (3) Data Inicio da Reserva
      (4) Data Fim da Reserva

2. Sempre que a reserva ultrapassar 10 dias, o sistema deverá calcular um desconto de 10% no valor final da diária.

3. O sistema deverá possibilitar a criação de um array ou lista de PESSOAS, SUITES e RESERVAS para que sejam cadastrados vários objetos de cada classe.

4. O sistema deverá possuir um MENU no console, com as opções:
   4.1. Cadastro
      4.1.1. Hospede
      4.1.2. Suite
      4.1.3. Reserva
   4.2. Consultar
      4.2.1. Hospede (apenas 1)
      4.2.2. Suite (Apenas 1)
      4.2.3. Reserva (Apenas 1)
   4.3. Listar
      4.3.1. Hospedes
      4.3.2. Suites
      4.3.3. Reservas
   4.4. Opção SAIR.
