using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf09_ConectarDB.MVVM.Data;

namespace Wpf09_ConectarDB.MVVM.Data
{
    class AccesoDatos
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=1234;database=sakila";

        //DataTable es un tabla
        //Funcion para llamar a un PA que no recibe parametros de entrada ni devuelve parametros de salida
        //Solo devuelve una consulta: SELECT
        //@return: DataTable
        public DataTable EjecutarProcedimiento(string nombrePA)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(nombrePA, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(tabla);
            }

            return tabla;
        }

        //DataSet es un conjunto de tablas (DataTable)
        //Funcion para llamar a un PA que recibe parametros de entrada
        //Devuelve una lista
        //@return :DataSet
        public DataSet EjecutarProcedimiento(string nombrePA, List<string> pNombreIn, List<Object> pIn)
        {
            DataSet datosResult = new DataSet();

            if(pNombreIn.Count == pIn.Count)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(nombrePA, conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    for (int i = 0; i < pNombreIn.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@" + pNombreIn[i], pIn[i]);
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    adapter.Fill(datosResult);
                }
            }

            return datosResult;
        }

        //DataSet es un conjunto de tablas (DataTable)
        //Funcion para llamar a un PA que recibe parametros de entrada
        //Devuelve una lista de Objetos con los parametros de salida
        //@return: List<Object>
        public List<Object> EjecutarProcedimiento(string nombrePA, List<string> pNombreIn, List<Object> pIn, List<Object> pNombreOut)
        {
            List<Object> listaResultado = new List<object>();

            if (pNombreIn.Count == pIn.Count)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(nombrePA, conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    for (int i = 0; i < pNombreIn.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@" + pNombreIn[i], pIn[i]);
                    }

                    //Recorremos el listado de nombre de los parametros de salida
                    foreach (var paramSalida in pNombreOut)
                    {
                        //Añadimos el param de salida al listado
                        cmd.Parameters.Add("@" + paramSalida, MySqlDbType.Int32);
                        //Buscamos el param de salida en el listado de parametros y configuramos que es de salida
                        cmd.Parameters["@" + paramSalida].Direction = ParameterDirection.Output;
                    }

                    //Ejecutamos la llamada al PA
                    cmd.ExecuteNonQuery();

                    //Recorremos los parametros de salida en la lista que veamos a devolver
                    for (int i = 0; i < pNombreOut.Count; i++)
                    {
                        listaResultado.Add(cmd.Parameters["@" + pNombreOut[i]].Value);
                    }
                }
            }
            return listaResultado;
        }
    }
}
// AGREGAR EN EL VIEWMODEL: using Wpf09_ConectarDB.MVVM.Data;

// Dentro del MainViewModel() agregar eso
//private AccesoDatos accesoDatos = new AccesoDatos();

//DataTable resultado = AccesoDatos.EjecutarProcedimiento(nombrePA, "sp_listado_actores");)

//foreach (DataRow row in resultado.Rows){ MessageBox.Show(messageBoxText.row[0].ToString()); }

//en el xaml
// xmlns:mvvm="clr-namespace:Wpf09_ConectarDB.MVVM.ViewModel"
//en application resources esto
//<mvvm:MainViewModel x:Key="MainViewModel"/>
