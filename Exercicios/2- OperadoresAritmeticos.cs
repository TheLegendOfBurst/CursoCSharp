using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    public class ExercicioOperadoresAritmeticos
    {
        /* 1. Questão: Crie um programa em C# que solicite ao usuário dois números inteiros e 
           calcule a soma desses números. Exiba o resultado com uma mensagem que informe a 
           soma dos dois números. */

        public static void Exercicio1()
        {

            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int soma = numero1 + numero2;
            Console.WriteLine($"A soma dos números {numero1} e {numero2} é {soma}.");
        }


        /* 2. Questão: Peça ao usuário para inserir dois números inteiros e calcule a diferença entre
           o primeiro e o segundo número. Exiba o resultado com uma mensagem que informe a
           subtração. */
        public static void Exercicio2()
        {
            
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int diferenca = numero1 - numero2;
            Console.WriteLine($"A diferença entre {numero1} e {numero2} é {diferenca}.");
        }

        /* 3. Questão: Solicite ao usuário para inserir dois números inteiros e calcule a
           multiplicação desses números. Exiba o resultado com uma mensagem que informe a
           multiplicação. */

        /* 4. Questão: Peça ao usuário para inserir dois números inteiros e calcule a divisão do
           primeiro número pelo segundo. Exiba o resultado com uma mensagem que informe a
           divisão. Inclua tratamento para divisão por zero. */

        /* 5. Questão: Solicite ao usuário para inserir dois números inteiros e calcule o resto da
           divisão do primeiro número pelo segundo. Exiba o resultado com uma mensagem que
           informe o resto da divisão. */

        /* 6. Questão: Peça ao usuário para inserir um número inteiro e, em seguida, exiba o
           número incrementado em 1. Utilize o operador de incremento ++. */

        /* 7. Questão: Solicite ao usuário para inserir um número inteiro e exiba o mesmo número
           decrementado em 1. Utilize o operador de decremento --. */

        /* 8. Questão: Crie um programa que solicite ao usuário para inserir dois números inteiros e
           calcule a média desses números. Exiba a média com uma mensagem informativa. */

        /* 9. Questão: Peça ao usuário para inserir três números inteiros e calcule a soma dos dois
           primeiros números e, em seguida, subtraia o terceiro número do resultado. Exiba o
           resultado com uma mensagem explicativa. */

        /* 10. Questão: Solicite ao usuário dois números inteiros e calcule o quadrado do primeiro
           número somado ao segundo número. Exiba o resultado com uma mensagem
           explicativa. */

        /* 11. Questão: Crie um programa que solicite ao usuário para inserir um valor e exiba o
           dobro desse valor e a metade desse valor. Utilize operadores aritméticos para fazer os
           cálculos. */

        /* 12. Questão: Peça ao usuário para inserir dois números inteiros e calcule o resultado da
           expressão (a + b) * (a - b). Exiba o resultado com uma mensagem informativa. */

        /* 13. Questão: Solicite ao usuário para inserir dois números inteiros e calcule a soma do
           quadrado do primeiro número com o quadrado do segundo número. Exiba o resultado
           com uma mensagem explicativa. */

        /* 14. Questão: Crie um programa que solicite ao usuário para inserir um número inteiro e
           calcule o valor do número ao cubo. Exiba o resultado com uma mensagem explicativa. */

        /* 15. Questão: Peça ao usuário para inserir dois números inteiros e calcule o resultado da
           expressão a * (b + a) / b. Exiba o resultado com uma mensagem informativa. */

        /* 16. Questão: Solicite ao usuário para inserir um número inteiro e calcule o quadrado da
           diferença entre o número e 5. Exiba o resultado com uma mensagem explicativa. */

        /* 17. Questão: Crie um programa que solicite ao usuário dois números inteiros e calcule a
           média aritmética entre eles. Exiba a média com uma mensagem explicativa. */

        /* 18. Questão: Peça ao usuário para inserir um valor em reais e calcule o valor em dólares,
           assumindo uma taxa de câmbio fixa de 5.0 reais por dólar. Exiba o resultado com uma
           mensagem explicativa. */

        /* 19. Questão: Solicite ao usuário para inserir a quantidade de dias e calcule a quantidade
           total de horas. Exiba o resultado com uma mensagem explicativa. */

        /* 20. Questão: Crie um programa que peça ao usuário para inserir a quantidade de horas e
           minutos e calcule o total em minutos. Exiba o resultado com uma mensagem
           explicativa. */

    }
}