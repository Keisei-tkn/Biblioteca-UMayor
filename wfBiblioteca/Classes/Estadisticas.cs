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
        public Material MaterialMasPedido;

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
            MaterialMasPedido = (Material)cantidades[5];

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
            Prestamo prs = new Prestamo();
            List<Prestamo> ListaPrestamo = prs.ObtenerAllPrestamos();
            Dictionary<string, int> nameCounts = new Dictionary<string, int>();
            foreach (Prestamo p in ListaPrestamo)
            {
                Material material = mat.ListaMaterial.Find(m => m.Id == p.IdMaterial);
                contMat++;
                if(material is Libro)
                {
                    contLib++;
                }else if (material is Revista)
                {
                    contRev++;
                }else if(material is Audiovisual)
                {
                    contAud++;
                }
                else
                {
                    contOtr++;
                }

                string id = material.Id;

                if (nameCounts.ContainsKey(id))
                    nameCounts[id]++;
                else
                    nameCounts[id] = 1;

            }
            string mostCommonId = nameCounts.OrderByDescending(x => x.Value).First().Key;
            Material mostCommonMaterial = mat.ListaMaterial.Find(mc => mc.Id == mostCommonId);
            cantidades[0] = contMat;
            cantidades[1] = contLib;
            cantidades[2] = contRev;
            cantidades[3] = contAud;
            cantidades[4] = contOtr;
            cantidades[5] = mostCommonMaterial;

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
