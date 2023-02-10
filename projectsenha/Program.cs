using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectsenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeusuario = "Usuario";
            string senha = "123";


            Console.Write("Usuario: ");
            string UsuarioInserido = Console.ReadLine();
            Console.WriteLine();


            Console.Write("Senha: ");
            string SenhaInserida = Console.ReadLine();
            Console.WriteLine();


            if (nomeusuario != UsuarioInserido || SenhaInserida != senha)
                Console.WriteLine("Usuario ou senha incorreta");
            else
                Console.WriteLine("Bem - vindo ao sistema");

            Console.ReadKey();
        }
    }
}
