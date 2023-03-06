// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;

Console.WriteLine("Hello, World!");
//criar vetor que ira armazenar as opçoes
/*gerador de palavras aleatorias
https://www.palabrasaleatorias.com/palavras-aleatorias.php
String[] palavras = new String[30] {"Arraia", "Tigre", "Veado", "Lagarto", 
    "Zebra", "Peixe espada", "Baiacu", "Galo", "Ovelha", "Polvo", "Lesma",
    "Avestruz","Cavalo","Peixe betta","Canário","Gato","Camelo","Papagaio",
    "Cisne","Hamster", "Pinguim","Galinha","Lagarto","Bacalhau",
    "Cavalo marinho","Cabra","Crocodilo","Cacatua","Leopardo","Panda"}; 
*/
List<String> cartas = new List<String>() { "Arraia","Gato", "Lagarto", "Tigre", "Veado","Tigre", "Veado","Gato", "Arraia", "Lagarto" };
//variaveis adicionais
int totalCartas = cartas.Count() ;
string[] acertos = new string[10] {"*", "*", "*", "*", "*", "*", "*", "*", "*", "*"}; 
int contAcertos=0;
int dificuldade = 0;




//exibir vetor
for (int i=0; i< totalCartas; i++)
{
    Console.Write((i+1) + " = " + cartas[i]+ "   ");
    if (i>0 && (i+1) % 5 == 0)
        Console.WriteLine("\r\n");

}

Console.WriteLine("\r\n Digite qualquer tecla para Continuar");
Console.ReadKey();
Console.Clear();
do
{
    Console.Clear();
    Console.WriteLine("Acertos");
    for (int i = 0; i < totalCartas; i++)
    {
        Console.Write((i + 1) + " = " + acertos[i] + "   ");
        if (i > 0 && (i + 1) % 5 == 0)
            Console.WriteLine("\r\n");

    }
    //seleciona primeira carta
    Console.WriteLine("\r\n Digite o número da primeira carta");
    int carta1 = int.Parse(Console.ReadLine()) -1;
    //seleciona segunda carta
    Console.WriteLine("\r\n Digite o número da segunda carta");
    int carta2 = int.Parse(Console.ReadLine()) - 1;
    //verifica se acertou
    if (cartas[carta1].Equals(cartas[carta2]))
        {
        Console.WriteLine(" \r\n Você acertou");
        contAcertos++;
        acertos[carta1] = cartas[carta1];
        acertos[carta2] = cartas[carta2];
    }
    else
        Console.WriteLine(" \r\n Você errou");

    Console.WriteLine("\r\n Digite qualquer tecla para Continuar");
    Console.ReadKey();
} while (contAcertos < totalCartas / 2);
Console.WriteLine("Você Ganhou");
//finalizar jogo


