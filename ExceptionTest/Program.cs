using System;

namespace ExceptionTest
{
    public class Program
    {
        private static void Main()
        {
            try
            {
                Console.Write("Insere um número inteiro: ");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Número inserido: {i}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Formato incorreto");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Numero demasiado grande");
            }
            finally
            {
                Console.WriteLine("Obrigado por teres utilizado este programa");
            }
        }
    }
}
