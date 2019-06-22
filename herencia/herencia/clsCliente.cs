using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    public class clsCliente
    {

        private int _idCliente;

       private string _Nombres;

        private string _Apellidos;

        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
    }
}
