using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACPMWS.Models
{
    public class facturaContpaq
    {
        public string razonSocial { get; set; }
        public string numeroCliente { get; set; }
        public string RFC { get; set; }
        public string servicio { get; set; }
        public string formaPago { get; set; }
        public string metodoPago { get; set; }
        public string usoCFDI { get; set; }
        public string montoServicio { get; set; }

    }
}