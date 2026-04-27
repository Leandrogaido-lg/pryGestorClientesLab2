using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryGestorClientesLab2
{
    internal class clsArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";
        Decimal total = 0;
        Int32 C = 0;
        public void Grabar(string cod, string nom, string deu, string lim)
        {
            //Abrir
            StreamWriter AD = new StreamWriter(NombreArchivo);
            //CArgar o leer
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.WriteLine(lim);
            //Cerrar
            AD.Close();
            AD.Dispose();

        }

        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];

            StreamReader AD = new StreamReader(NombreArchivo);

            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');

                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
        }

        public Int32 CantidadClientes()
        {

            string DatosLeidos;
           
            //abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                C++;
                DatosLeidos = AD.ReadLine();
            }
            //cerrar
            AD.Close();
            AD.Dispose();
            return C;



        }
        public Decimal DeudaClientes()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            
            //abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                total = total + Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }
            //cerrar
            AD.Close();
            AD.Dispose();
            return total;
        }
        public Decimal PromedioDeuda()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            
            //abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                C++;
                VecDatos = DatosLeidos.Split(';');
                total = total + Convert.ToDecimal(VecDatos[2]);

                DatosLeidos = AD.ReadLine();
            }
            //cerrar
            AD.Close();
            AD.Dispose();
            return total/C;
        }

        public Decimal PromedioDeuda2()
        { 
        Decimal promedio = 0;
            promedio = total / C;
               return promedio;


        }
        public void ListarDeudores(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];

            StreamReader AD = new StreamReader(NombreArchivo);

            DatosLeidos = AD.ReadLine();

            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');

                if (Convert.ToInt32(VecDatos[2]) > 0) 
                {
                    Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);



                }
                
                DatosLeidos = AD.ReadLine();
            }
                
            AD.Close();
            AD.Dispose();
        }
    }
}
