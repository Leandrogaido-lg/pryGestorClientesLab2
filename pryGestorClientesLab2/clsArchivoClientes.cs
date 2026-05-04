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

        private struct RegClientes
        {
            public Int32 Codigo;
            public String Nombre;
            public Decimal Deuda;
            public Decimal Limite;
        }

        private RegClientes[] VecClientes = new RegClientes[1500];
        private Int32 IND = 0; 
        

        private void CargarVector()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];

            StreamReader AD = new StreamReader(NombreArchivo);

            DatosLeidos = AD.ReadLine();
            
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                VecClientes[IND].Codigo = Convert.ToInt32(VecDatos[0]);
                VecClientes[IND].Nombre = VecDatos[1];
                VecClientes[IND].Deuda = Convert.ToDecimal(VecDatos[2]);
                VecClientes[IND].Limite = Convert.ToDecimal(VecDatos[3]);
                IND++;
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();


        }

        private void OrdenarVector()
        {
            RegClientes Aux; //crea una variable auxiliar para guardar el cliente actual

            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1; i++) //recorre el vector
                {
                    if (VecClientes[i].Codigo > VecClientes[i + 1].Codigo) //compara el codigo del cliente actual con el siguiente
                    {

                        Aux = VecClientes[i]; //guarda el cliente actual en la variable auxiliar
                        VecClientes[i] = VecClientes[i + 1]; //asigna el cliente siguiente al cliente actual
                        VecClientes[i + 1] = Aux; //asigna el cliente guardado en la variable auxiliar al cliente siguiente
                    }

                }
            }
        }

        private void ReescribirArchivo()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false);
            for (Int32 i = 0; i < IND; i++)
            {
                AD.Write(VecClientes[i].Codigo);
                AD.Write(";");
                AD.Write(VecClientes[i].Nombre);
                AD.Write(";");
                AD.Write(VecClientes[i].Deuda);
                AD.Write(";");
                AD.WriteLine(VecClientes[i].Limite);
            }
            AD.Close();
            AD.Dispose();
        }

        public void OrdenarArchivo()
        {
            CargarVector();
            OrdenarVector();
            ReescribirArchivo();
        }

        public void Grabar(string cod, string nom, string deu, string lim)
        {
            //Abrir
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
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
                Int32 C = 0;

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
            Decimal total = 0;

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
            Decimal total = 0;
             Int32 C = 0;

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
            return total / C;
        }

        public Decimal TotalDeuda()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            decimal total = 0;
             StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                total = total + Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
             return total;
            


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

        public void GenerarReporte()
        {

            string DatosLeidos;
            string[] VecDatos = new string[4];

            Int32 C = 0;
            Decimal total = 0;

            StreamWriter reporte = new StreamWriter("Reporte.csv", false);

            StreamReader AD = new StreamReader(NombreArchivo);

            reporte.WriteLine("Listado de Clientes");
            reporte.WriteLine("");
            reporte.WriteLine("Codigo;Nombre;Deuda;Limite");

            DatosLeidos = AD.ReadLine();

           
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');

                reporte.Write(VecDatos[0]);
                reporte.Write(";");
                reporte.Write(VecDatos[1]);
                reporte.Write(";");
                reporte.Write(VecDatos[3]);
                reporte.Write(";");
                reporte.WriteLine(VecDatos[2]);


                DatosLeidos = AD.ReadLine();
                C++;
                total = total + Convert.ToDecimal(VecDatos[2]);

            }

            AD.Close();
            AD.Dispose();
            reporte.Write("Total de deudas:;;");
            reporte.WriteLine(total);
            reporte.Write("Cantidad de Clientes:;;");
            reporte.WriteLine(C);
            reporte.Write("Promedio de Deuda:;;");
            reporte.WriteLine(total/C);

            reporte.Close();
            reporte.Dispose();
        }
    }


      
}
