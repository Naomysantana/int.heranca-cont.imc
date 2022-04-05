using System; 

namespace aula3VSC
{
    class Program

    static void Main( string [] args)

    float altura;
    float peso;
    float imc;

    console.writeLine("Digite seu nome: ");
    string nome = console.ReadLine();

    console.writeLine("Digite sua altura: ");
    altura = float.Parse(console.ReadLine());

    console.writeLine("Digite seu peso: ");
    peso = float.Parse(console.ReadLine());

    imc= peso / (altura * altura);

    console.writeLine("Seu imc é: " + imc)


}