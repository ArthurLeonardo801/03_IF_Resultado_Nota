using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCsharp02
{/*Faça um programa que leia o nome e o valor de 2 notas de um aluno
            depois faça a média das duas notas
            se a média ficou maior que 5 aluno aprovado
            menor que 5 aluno reprovado

   se a nota for entre 0, você não aprendeu nada
            se a nota for entre 1 a 4 você está reprovado
            se a nota for entre 5 a 7 você passou raspando
            se a nota for 8 ou 9 você mandou bem
            se a nota for 10, parabéns vc é muito inteligente

 */
    class Program
    {
        Console.WriteLine("Informe o nome do aluno 1: ");
string nome1 = Console.ReadLine();
        Console.WriteLine("Informe a nota do aluno 1: ");
int nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota do aluno 1: ");
int nota2 = Convert.ToInt32(Console.ReadLine());
        int media1 = (nota1 + nota2) / 2;

if (media1 == 0)
{
    Console.WriteLine("O Aluno: " + nome1 + " Não Aprendeu nada! ");
}
else if (media1 <= 1 && media1 <= 4)
{
    Console.WriteLine("O Aluno: " + nome1 + " foi reprovado! ");
}
else if (media1 >= 5 && media1 <= 7)
{
    Console.WriteLine("O Aluno: " + nome1 + " Passou raspando! ");
}
else if (media1 == 8 || media1 == 9)
{
    Console.WriteLine(" Aluno: " + nome1 + " ,mandou bem! ");
}
else
{
    Console.WriteLine(" Aluno: " + nome1 + ", Parabéns você é muito inteligente! ");
}
}
}
}

    }
}




