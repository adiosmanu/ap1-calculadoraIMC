﻿//variavel para controle do loop
string? continuar;

do
{
    //coleta de dados
    Console.WriteLine("Vamos calcular seu IMC. Por favor, digite seu nome: ");
    string? nome = Console.ReadLine();
    Console.WriteLine("Qual a sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Qual a  sua altura: ");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Qual o seu peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());
    

    //calculo do IMC

    double imc = peso / (altura * altura);

    string CalculoImc;
    if (imc < 18.5)
    CalculoImc = "Você está abaixo do peso ideial!";
    else if (imc < 24.9)
    CalculoImc = "Seu peso está Normal!";
    else if (imc < 29.9)
    CalculoImc = "VocÊ está em Sobrepeso!";
    else
    CalculoImc = "Você está obeso!";

    string FaixaEtaria;
    if (idade < 12)
    FaixaEtaria = "Criança";
    else if (idade < 18)
    FaixaEtaria = "Adolescente";
    else if (idade < 60)
    FaixaEtaria = "Adulto";
    else
    FaixaEtaria = "Idoso";

    //gerar resultado
    Console.WriteLine("\n--------------------- Calculadora de IMC ---------------------");
    Console.WriteLine("Nome:" + nome);
    Console.WriteLine($"Idade: {idade} anos");
    Console.WriteLine($"IMC: {imc:F2}, {CalculoImc}");
    Console.WriteLine($"Faixa etária: {FaixaEtaria}");

    //perguntar para continuar 
    Console.WriteLine("\nDeseja gerar um novo cálculo? (S/N): ");
    continuar = Console.ReadLine()?.ToUpper();
  
}while(continuar == "S");

Console.WriteLine("Obrigado por fazer o teste! Cuide seus hábitos!");
    
