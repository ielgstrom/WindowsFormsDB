using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsDB
{
    class InitializerDB
    {
        SqlConnection connection = null;
        public InitializerDB()
        {
            try
            {

           connection = new SqlConnection("Data Source=217.71.207.123,54321;Initial Catalog=Ignasi_Employees;Persist Security Info=True;User ID=sa;Password=123456789");
            connection.Open();
            //labelConnect.Text = "Estado conexión: Conectado";
            }
            catch(Exception r)
            {
                MessageBox.Show("Error al iniciar la BBDD: " + r.Message);
            }
        }
        public SqlConnection connectionReturn()
        {
            return connection;
        }
    }
}
