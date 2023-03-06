using System;

namespace zeca_c__aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, resultado;
            string operador;

            Console.WriteLine("primeiro valor?");
            valor1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Operador?");
            operador = Console.ReadLine();

            Console.WriteLine("segundo valor?");
            valor2 = Convert.ToInt16(Console.ReadLine());

            if(operador == "+"){
               resultado = valor1 + valor2;
                Console.WriteLine(resultado);
            }else if(operador == "-"){
                resultado = valor1 - valor2;
                Console.WriteLine(resultado);
            }else if(operador == "*"){
                resultado = valor1 * valor2;
                Console.WriteLine(resultado);
            }else if(operador == "/"){
                resultado = valor1 / valor2;
                Console.WriteLine(resultado);
            }else{
                Console.WriteLine("só é aceito os seguntes operadores: *, -, /, +");
            }


        }
    }
}
