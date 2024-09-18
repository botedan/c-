using System.ComponentModel;
using DIO_XP.models;



List<string> listastring = new List<string>();


listastring.Add("SP");
listastring.Add("BA");
listastring.Add("MS");
listastring.Add("RJ");


Console.WriteLine($"itens na minha lista:{listastring.Count} - capacidade: {listastring.Capacity}");

listastring.Add("SC");
Console.WriteLine($"itens na minha lista:{listastring.Count} - capacidade: {listastring.Capacity}");


listastring.Remove("MG");
Console.WriteLine($"itens na minha lista:{listastring.Count} - capacidade: {listastring.Capacity}");










// Console.WriteLine("Percorrendo pelo For");

// for(int contador = 0; contador < listastring.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} = {listastring[contador]}");
// }


// Console.WriteLine("Percorrendo pelo Foreach");
// int contadorforeach = 0;
// foreach(string item in listastring)
// {
//     Console.WriteLine($"Posição N° {contadorforeach} = {item}");
//     contadorforeach++;
// }












// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;



// int[] ArrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, ArrayInteirosDobrado, arrayInteiros.Length);



// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// //percorrendo array pelo FOR
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} = {arrayInteiros[contador]}");
// }











//PERCORRENDO PELO fOREACH
// int contadorforeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorforeach} = {valor}");
//     contadorforeach++; 
// }
























// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         string opcao;

//         while (true)
//         {
//             Console.Clear();
//             Console.WriteLine("Digite uma opoção: ");
//             Console.WriteLine("1 - Cadastrar cliente: ");
//             Console.WriteLine("2 - Buscar cliente: ");
//             Console.WriteLine("3 - Apagar cliente: ");
//             Console.WriteLine("4 - Encerrar");

//             opcao = Console.ReadLine();

//             switch (opcao)
//             {
//                 case "1":
//                     Console.WriteLine("Cadastrando cliente");
//                     break;

//                 case "2":
//                     Console.WriteLine("Buscando cliente");
//                     break;

//                 case "3":
//                     Console.WriteLine("Apagando cliente");
//                     break;

//                 case "4":
//                     Console.WriteLine("Encerrando programa");
//                     Environment.Exit(0);
//                     return;

//                 default:
//                     Console.WriteLine("Opção inválida");
//                     break;

//             }
//         }
//     }
// }





















// int soma = 0,  numero = 0;

// do
// {
//     Console.WriteLine("digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

















// int numero = 5;
// int contador = 0;


// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1 }° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;
// }
















// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero*contador}" );
// }

// Console.WriteLine($"{numero} x 1 = {numero*1}" );










// Calculadora calc = new Calculadora();

// calc.soma(30,10);
// calc.Subtrair(30,50);
// calc.Multiplicar(15,45);
// calc.Dividir(2,2);

// calc.potencia(3,3);

// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);


// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("incrementando o 10");    
// numero++;
// Console.WriteLine(numero);


// calc.RaizQuadrada(9);












// using DIO_XP.models;

// Pessoa p = new Pessoa();

// p.Nome = "Daniel";
// p.Idade = 26;
// p.Apresentar();

