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
    }
}
