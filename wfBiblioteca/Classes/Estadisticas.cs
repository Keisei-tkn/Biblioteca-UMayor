using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfBiblioteca.Classes
{
    class Estadisticas
    {
        public int CantidadPedidosMaterial;
        public int CantidadPedidosLibro;
        public int CantidadPedidosRevista;
        public int CantidadPedidosAudiovisual;
        public int CantidadPedidosOtro;
        public string MaterialMasPedido;

        public decimal DineroTotalMultas;
        public int CantidadAtrasos;


        public Estadisticas()
        {
            object[] cantidades = ObtenerCantidades();
            object[] multa_atrasos = ObtenerAtrasoMulta();

            CantidadPedidosMaterial = (int)cantidades[0];
            CantidadPedidosLibro = (int)cantidades[1];
            CantidadPedidosRevista = (int)cantidades[2];
            CantidadPedidosAudiovisual = (int)cantidades[3];
            CantidadPedidosOtro = (int)cantidades[4];
            MaterialMasPedido = cantidades[5].ToString();

            DineroTotalMultas = (decimal)multa_atrasos[0];
            CantidadAtrasos = (int)multa_atrasos[1];

        }

        public object[] ObtenerCantidades()
        {
            object[] cantidades = new object[6];
            int contMat = 0;
            int contLib = 0;
            int contRev = 0;
            int contAud = 0;
            int contOtr = 0;
            MaterialDB mat = new MaterialDB();
            Dictionary<string, int> nameCounts = new Dictionary<string, int>();
            foreach (Material m in mat.ListaMaterial)
            {
                contMat++;
                if(m is Libro)
                {
                    contLib++;
                }else if (m is Revista)
                {
                    contRev++;
                }else if(m is Audiovisual)
                {
                    contAud++;
                }
                else
                {
                    contOtr++;
                }

                string name = m.Nombre;

                if (nameCounts.ContainsKey(name))
                    nameCounts[name]++;
                else
                    nameCounts[name] = 1;

            }
            var mostCommonName = nameCounts.OrderByDescending(x => x.Value).First().Key;

            cantidades[0] = contMat;
            cantidades[1] = contLib;
            cantidades[2] = contRev;
            cantidades[3] = contAud;
            cantidades[4] = contOtr;
            cantidades[5] = mostCommonName;

            return cantidades;
        }

        public object[] ObtenerAtrasoMulta()
        {
            object[] datos = new object[2];
            Atraso atr = new Atraso();
            List<Atraso> ListaAtraso = atr.ObtenerAllAtrasos();
            decimal TotalMulta = 0;
            int contAtrasos = 0;

            foreach(Atraso a in ListaAtraso)
            {
                contAtrasos++;
                TotalMulta += a.Multa;
            }
            datos[0] = TotalMulta;
            datos[1] = contAtrasos;

            return datos;
        }
    }
}
