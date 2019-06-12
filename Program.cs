/*
 * Created by SharpDevelop.
 * User: ADM
 * Date: 10/06/2019
 * Time: 19:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Atividade
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Bruno Motta em corpo e alma kkkkk
			
			int cont = 0;
			
			Console.WriteLine("Vamos ver seus conheciementos através do Quiz. Escolha uma alternativa correta e obtenha a maior pontuação!");
			Console.WriteLine("Informe um numero da opção: 1, 2, 3 e 4.");
			Console.WriteLine();
			
			int Opção1;
			Console.WriteLine("Tenho dois pacotes de biscoitos com 2 cada, quantos eu tenho?");
			Console.WriteLine("1 - Cinco");
			Console.WriteLine("2 - Seis");
			Console.WriteLine("3 - Quadro");
			Console.WriteLine("4 - Dois");
			Opção1=int.Parse(Console.ReadLine());
			Console.WriteLine();
				
			
		    switch (Opção1)
		    { 
		    	case 1:
		    		Console.WriteLine("Errado");
		    		Console.WriteLine();
		    		break;
		    	case 2:
		    		Console.WriteLine("Errado");
		    		Console.WriteLine();
		    		break;
		    	case 3:
		    		Console.WriteLine("Errado");
		    		Console.WriteLine();
		    		break;
		    	case 4:
		    		Console.WriteLine("Parabéns, Acertou!");
		    		cont++;
		    		Console.WriteLine();
		    		break;
		    	default:
		    		Console.WriteLine("Opa! tente uma opção valida.");
		    		Console.WriteLine();
		    		break;
		    }
		    
		    int Opção2; 
		    Console.WriteLine("Em um Iphone você pode errar a senha somente 10 vezes, você erra 8, quantas você errou?");
		    Console.WriteLine("1 - Duas");
		    Console.WriteLine("2 - Sete");
		    Console.WriteLine("3 - Oito");
		    Console.WriteLine("4 - Seis");
		    Opção2= int.Parse(Console.ReadLine());
		    Console.WriteLine();
		                     
		    
		    switch (Opção2)
		    {
		    	case 1:
		    		Console.WriteLine("Errado");
		    		Console.WriteLine();
		    		break;
		    	case 2:
		    		Console.WriteLine("Errado");
		    		Console.WriteLine();
		    		break;
		    	case 3:
		    		Console.WriteLine("Parabéns, Acertou!");
		    		cont++;
		    		Console.WriteLine();
		    		break;
		    	case 4:
		    		Console.WriteLine("Errado");
		    		Console.WriteLine();
		    		break;
		    	default:
		    		Console.WriteLine("Opa! tente uma opção valida.");
		    		Console.WriteLine();
		    		break;
		    }
		    
		    int Opção3;
		    Console.WriteLine("Eu 200 moedas e quero somar 2, quantas vezes vou precisar somar 2 para chegar em 200 moedas?");
		    Console.WriteLine("1 - 50");
		    Console.WriteLine("2 - 80");
		    Console.WriteLine("3 - 100");
		    Console.WriteLine("4 - 200");
		    Opção3=int.Parse(Console.ReadLine());
		    Console.WriteLine();
		    
		    switch (Opção3)
		    { 
		    	case 1:
		    		Console.WriteLine("Errado");
		    		Console.WriteLine();
		    		break;
		    	case 2:
		    		Console.WriteLine("Errado");
		    		Console.WriteLine();
		    		break;
		    	case 3: 
		    		Console.WriteLine("Parabéns, Acertou!");
		    		cont++;
		    		  Console.WriteLine();
		    		break;
		    	case 4:
		    		Console.WriteLine("Nossa passou longe viu. KKK, Errado");
		    		Console.WriteLine();
		    		break;
		    	default:
		    		Console.WriteLine("Opa! tente uma opção valida.");
		    		Console.WriteLine();
		    		break;
		    }
		    
		    int Opção4;
		    Console.WriteLine("O Brasil faz fronteira com Uruguai e Uruguai com a Argentina e a Argentina com Chile, qual país Brasil não faz fronteira?");
		    Console.WriteLine("1 - Argentina");
		    Console.WriteLine("2 - Uruguai");
		    Console.WriteLine("3 - Chile");
		    Console.WriteLine("4 - Brasil");
		    Opção4=int.Parse(Console.ReadLine());
		    Console.WriteLine();
		    
		    switch (Opção4)
		    {
		    	case 1: 
		    		Console.WriteLine("Errado, Brasil faz sim fronteira com Argentina!");
		    		Console.WriteLine();
		    		break;
		    	case 2:
		    		Console.WriteLine("Errado, Brasil faz sim fronteira com Uruguai!");
		    		Console.WriteLine();
		    		break;
		    	case 3:
		    		Console.WriteLine("Parabéns, Acertou Gênio!!!");
		    		cont++;
		    			Console.WriteLine();
		    		break;
		    	case 4:
		    		Console.WriteLine("Errado, Estude mais Geografia, Viu?");
		    		Console.WriteLine();
		    		break;
		    	default: 
		    		Console.WriteLine("Opa! tente uma opção valida.");
		    		Console.WriteLine();
		    		break;
		    }
		    
		    Console.WriteLine("Opa! vamos ver sua pontuação? e total de pontos foi: " + cont);
		    Console.WriteLine();
		    Console.ReadKey();
		    
		    }

		}
	}