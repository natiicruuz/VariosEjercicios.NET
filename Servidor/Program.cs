using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Servidor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Servidor iniciado");
            Servidorsalas.IniciarServidor();
        }
    }
}