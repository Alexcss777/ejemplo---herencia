using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            clsClienteventas Cliente;
            // INTANCIA DE LA CLASE
            Cliente = new clsClienteventas();

            Cliente.IdCliente = 123;
            Cliente.Apellidos = "pon atencion";
            Cliente.Nombres = "Jose Luis";
            Cliente.RFC = "DSNMFSD";
            Cliente.Direccion = "Inserte aqui direccion de CESCA";
            Cliente.Municipio = "Tijuana es un municipio? :/";
            Cliente.EsCredito = true;

            Console.WriteLine(Cliente.IdCliente+ "  "+Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Municipio);


            if (Cliente.EsCredito)
                Console.WriteLine("el cliente tiene credito");
            else
                Console.WriteLine("el cliente no tiene credito");


            Console.ReadKey();

                
        }
    }
}
