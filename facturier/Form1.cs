using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public List<firma> firme = new List<firma>();
        public List<persoana> persoane = new List<persoana>();


        public List<factura> facturi = new List<factura>();


        public List<produs> produse = new List<produs>();


        //init from zero
        public int nrcurentfa = 0;
        public int nrcurentde = 0;
        public int nrcurentpr = 0;

        public void adaugaprodusnou()
        {
            produse.Add(new produs());
            produse[nrcurentpr].idprodus = "00000000001pr";
            produse[nrcurentpr].denumire = "paine alba"; ;
            produse[nrcurentpr].categorietva = "8"; ;
            produse[nrcurentpr].idfurnizor = "00000000001fu"; ;
            produse[nrcurentpr].date = "paine alba marca sibiu"; ;
            produse[nrcurentpr].iddomeniu = "00000000001do"; ;

        nrcurentpr++;
        }

        public void adaugafacturanoua()
        {
           


            facturi.Add(new factura());
            facturi[nrcurentfa].idfactura = "0000000001fa";
            facturi[nrcurentfa].idpersoana = "0000000000001pe";
            facturi[nrcurentfa].idfirma = "00000000000002fi";
            facturi[nrcurentfa].data = DateTime.Now;
            facturi[nrcurentfa].detaliifactura.Add(new detaliu());

                     nrcurentfa++;
       
        }

        public void adaugadetaliifactura()
        {
            facturi[nrcurentfa].detaliifactura[nrcurentde].iddetaliu = "00000000001de";
            facturi[nrcurentfa].detaliifactura[nrcurentde].idprodus = "00000000001pr";
            facturi[nrcurentfa].detaliifactura[nrcurentde].um = "buc";
            facturi[nrcurentfa].detaliifactura[nrcurentde].bucati = 10;
            facturi[nrcurentfa].detaliifactura[nrcurentde].pretperbucata = 3.50f;
            facturi[nrcurentfa].detaliifactura[nrcurentde].cotatva = 8.0f;
            facturi[nrcurentfa].detaliifactura[nrcurentde].pretcutvaperbucata = facturi[nrcurentfa].detaliifactura[nrcurentde].pretperbucata * facturi[nrcurentfa].detaliifactura[nrcurentde].cotatva;
            facturi[nrcurentfa].detaliifactura[nrcurentde].prettotal = facturi[nrcurentfa].detaliifactura[nrcurentde].pretperbucata * facturi[nrcurentfa].detaliifactura[nrcurentde].bucati;
            facturi[nrcurentfa].detaliifactura[nrcurentde].pretcutvatotal = facturi[nrcurentfa].detaliifactura[nrcurentde].pretcutvaperbucata * facturi[nrcurentfa].detaliifactura[nrcurentde].bucati;

            nrcurentde++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
