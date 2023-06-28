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
        public List<Material> MaterialMasPedido;
        public List<int> CantMaterialMasPedido;

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
            MaterialMasPedido = (List<Material>)cantidades[5];
            CantMaterialMasPedido = (List<int>)cantidades[6];

            DineroTotalMultas = (decimal)multa_atrasos[0];
            CantidadAtrasos = (int)multa_atrasos[1];

        }

        public object[] ObtenerCantidades()
        {
            object[] cantidades = new object[7];
            int contMat = 0;
            int contLib = 0;
            int contRev = 0;
            int contAud = 0;
            int contOtr = 0;
            MaterialDB mat = new MaterialDB();
            Prestamo prs = new Prestamo();
            List<Material> TopMaterial = new List<Material>();
            List<int> IntTopMaterial = new List<int>();
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
            string secondId = nameCounts.OrderByDescending(x => x.Value).ElementAt(1).Key;
            string thirdId = nameCounts.OrderByDescending(x => x.Value).ElementAt(2).Key;

            int intMostCommonId = nameCounts.OrderByDescending(x => x.Value).First().Value;
            int intSecondId = nameCounts.OrderByDescending(x => x.Value).ElementAt(1).Value;
            int intThirdId = nameCounts.OrderByDescending(x => x.Value).ElementAt(2).Value;

            Material mostCommonMaterial = mat.ListaMaterial.Find(mc => mc.Id == mostCommonId);
            Material secondMaterial = mat.ListaMaterial.Find(ms => ms.Id == secondId);
            Material thirdMaterial = mat.ListaMaterial.Find(mt => mt.Id == thirdId);

            TopMaterial.Add(mostCommonMaterial);
            TopMaterial.Add(secondMaterial);
            TopMaterial.Add(thirdMaterial);

            IntTopMaterial.Add(intMostCommonId);
            IntTopMaterial.Add(intSecondId);
            IntTopMaterial.Add(intThirdId);

            cantidades[0] = contMat;
            cantidades[1] = contLib;
            cantidades[2] = contRev;
            cantidades[3] = contAud;
            cantidades[4] = contOtr;
            cantidades[5] = TopMaterial;
            cantidades[6] = IntTopMaterial;

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
