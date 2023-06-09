﻿using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;
using bytebank_ADM.SistemaInterno;

internal class Program
{
    static void Main(string[] args)
    {
        #region
        //Funcionario pedro = new Funcionario("123456789", 2000);
        //pedro.Nome = "Pedro Malazartes";

        //Console.WriteLine(pedro.Nome);
        //Console.WriteLine(pedro.GetBonificacao());

        //Funcionario marcos = new Funcionario("123321123", 2000);
        //marcos.Nome = "Marcos Bandeira";

        //Console.WriteLine(marcos.Nome);
        //Console.WriteLine(marcos.GetBonificacao());

        //Diretor maria = new Diretor("987654321", 5000);
        //maria.Nome = "Maria Peixoto";

        //Console.WriteLine(maria.Nome);
        //Console.WriteLine(maria.GetBonificacao());

        //GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
        //gerenciador.Registrar(pedro);
        //gerenciador.Registrar(maria);
        //gerenciador.Registrar(marcos);

        //Console.WriteLine("\nTotal de bonificações: " + gerenciador.TotalDeBonificacao);
        //Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

        //pedro.AumentarSalario();
        //marcos.AumentarSalario();
        //maria.AumentarSalario();

        //Console.WriteLine("\nNovo salário do Pedro: " + pedro.Salario);
        //Console.WriteLine("Novo salário do Marcos: " + marcos.Salario);
        //Console.WriteLine("Novo salário da Maria: " + maria.Salario);
        #endregion
        //CalcularBonificacao();
        UsarSistema();
    }
    static void CalcularBonificacao()
    {
        GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

        Designer ulisses = new Designer("123456");
        ulisses.Nome = "Ulisses Souza";

        Diretor paula = new Diretor("987456");
        paula.Nome = "Paula Souza";

        Auxiliar igor = new Auxiliar("74581");
        igor.Nome = "Igor Dias";

        GerenteDeContas camila = new GerenteDeContas("852963");
        camila.Nome = "Camila Oliveira";

        gerenciador.Registrar(camila);
        gerenciador.Registrar(paula);
        gerenciador.Registrar(igor);
        gerenciador.Registrar(ulisses);

        Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
    }

    static void UsarSistema()
    {
        SistemaInterno sistema = new SistemaInterno();

        Diretor amanda = new Diretor("147258");
        amanda.Nome = "Amanda Novaes";
        amanda.Senha = "123";

        GerenteDeContas ursula = new GerenteDeContas("369258");
        ursula.Nome = "Ursula Alcantara";
        ursula.Senha = "789";

        sistema.Logar(amanda, "123");
        sistema.Logar(ursula, "789");
    }

}