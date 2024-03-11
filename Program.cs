// 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma 
// dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), 
// escreva um programa na linguagem que desejar onde, informado um número, 
// ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o 
// número informado pertence ou não a sequência.

using System.Globalization;
int numero, acumulador, ultimoTermo;

Console.Write ("Informe o número desejado para saber se ele pertence à sequência de fibonacci: ");
numero = Convert.ToInt32 (Console.ReadLine ());

if (numero == 0 || numero == 1){
    Console.Write ("{0} pertence à sequência de fibonacci ", numero);
}
else {
    for (acumulador = 2, ultimoTermo = 1; acumulador < numero;){
        acumulador += ultimoTermo;
        ultimoTermo = acumulador - ultimoTermo;
    }
    if (numero == acumulador){
        Console.Write ("{0} pertence à sequência de fibonacci ", numero);
    }
    else {
        Console.Write ("{0} não pertence à sequência de fibonacci ", numero);
    }
}