using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturier
{
    public class factura
    {
        public string idfactura;
        public DateTime data;
        public string idfirma;
        public string idpersoana;
        public List<detaliu> detaliifactura = new List<detaliu>();
        public float prettotalcutva;
        public float tvatotal;
        public float pretfaratva;
        public void adaugadetaliu() { }
        public void stergedetaliu() { }
        public void calculeazatotlul() { }


    }
}
