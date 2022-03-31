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
using WindowsFormsDB.DAL;

namespace WindowsFormsDB
{
    public partial class Form1 : Form
    {
 
        List<Job> listaTrabajos = new List<Job>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (connection == null && connection.State != ConnectionState.Open) return;
            var jobToUdate = new DALJobs();
            try
            {
                jobToUdate.AddJob(textNombreJob.Text, Convert.ToDouble(textSalarioMIN.Text), Convert.ToDouble(textSalarioMax.Text));
                MessageBox.Show("Puesto añadido correctamente");
                buttonSelect_Click(sender, e);
                deletePosicion.Visible = false;
                btnChangeData.Visible = false;
            }
            catch (Exception r)
            {
                MessageBox.Show("Error en el insert: " + r.Message);
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            var accionJobs = new DALJobs();
            listBoxJobs.Items.Clear();
            listaTrabajos.Clear();
            listaTrabajos = accionJobs.getListJobs(listaTrabajos);
            foreach (Job element in listaTrabajos)
            {
                listBoxJobs.Items.Add(element);
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
                DALJobs puestaAEliminar = new DALJobs();
                var confirmResult = MessageBox.Show("Seguro que quieres eliminar " + listaTrabajos[listBoxJobs.SelectedIndex].getNombrePosicion()+" de la lista?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                puestaAEliminar.delteJob(listaTrabajos[listBoxJobs.SelectedIndex].getID());
                buttonSelect_Click(sender, e);
                deletePosicion.Visible = false;
                btnChangeData.Visible = false;
                }
            }
            catch(Exception rt)
            {
                MessageBox.Show("Error al eliminar: " + rt);
            }
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            EditJob js = new EditJob(listaTrabajos[listBoxJobs.SelectedIndex]);
            js.ShowDialog();
            buttonSelect_Click(sender, e);
            deletePosicion.Visible = false;
            btnChangeData.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            buttonInsertJob.Enabled = true;
            buttonSelect.Enabled = true;
            textNombreJob.Enabled = true;
            textSalarioMIN.Enabled = true;
            textSalarioMax.Enabled = true;
        }
    }
}
