﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    public class clsClienteventas : clsCliente
    {


        private string _RFC;

        private string _Direccion;

        private string _Municipio;

        private bool _EsCredito;

        public string RFC { get => _RFC; set => _RFC = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public bool EsCredito { get => _EsCredito; set => _EsCredito = value; }
    }
}
