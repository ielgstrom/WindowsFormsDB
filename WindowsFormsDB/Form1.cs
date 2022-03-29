using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsDB
{
    public partial class Form1 : Form
    {
        SqlConnection connection = null;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("Data Source=217.71.207.123,54321;Initial Catalog=Ignasi_Employees;Persist Security Info=True;User ID=sa;Password=123456789");
                connection.Open();
                labelConnect.Text = "Estado conexión: Conectado";
                Console.WriteLine("Connected");
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
                buttonInsertJob.Enabled = true;
                buttonSelect.Enabled = true;
                textNombreJob.Enabled = true;
                textSalarioMIN.Enabled = true;
                textSalarioMax.Enabled = true;
            }
            catch (Exception d)
            {
                MessageBox.Show("Error de conexion: "+d.Message);
            }

        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                labelConnect.Text = "Estado conexión: Desconectado";
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                buttonInsertJob.Enabled = false;
                buttonSelect.Enabled = false;
                textNombreJob.Enabled = false;
                textSalarioMIN.Enabled = false;
                textSalarioMax.Enabled = false;

            }
            catch (Exception d)
            {
                MessageBox.Show("Error de desconexion: " + d.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection == null && connection.State != ConnectionState.Open) return;
            try
            { 
                Job trabajo = new Job(textNombreJob.Text, Convert.ToDouble(textSalarioMIN.Text), Convert.ToDouble(textSalarioMax.Text));
                trabajo.insertIntoDB(connection);
                textNombreJob.Text = "";
                textSalarioMIN.Text = "";
                textSalarioMax.Text = "";
                MessageBox.Show("Puesto añadido correctamente");
            }
            catch (Exception r)
            {
                MessageBox.Show("Error en el insert: " + r.Message);
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena = "SELECT * FROM JOBS";
                SqlCommand cmd = new SqlCommand(cadena, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string valor = dr[1].ToString()+ ": "+ dr[2].ToString() + "€ y maximo de " + dr[3].ToString() + "€";
                    
                    listBoxJobs.Items.Add(valor);

                }
                dr.Close();
            }
            catch(Exception tt)
            {
                MessageBox.Show("Error en select: "+ tt);
            }
        }

        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            deletePosicion.Visible = true;
            btnChangeData.Visible = true;

        }

        private void deletePosicion_Click(object sender, EventArgs e)
        {
            try
            {
            Persona personaAEliminar = new Persona()
            }
            catch(Exception rt)
            {
                MessageBox.Show("Error al eliminar: " + rt);
            }
        }
    }
}
