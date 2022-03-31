using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDB.DAL;
using System.Data.SqlClient;

namespace WindowsFormsDB
{
    partial class EditJob : Form
    {
        Job trabajadorAUpdatear = null;
        public EditJob(Job trabajadorAUpdatear)
        {
            this.trabajadorAUpdatear = trabajadorAUpdatear;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditJob_Load(object sender, EventArgs e)
        {
            txtPuesto.Text = trabajadorAUpdatear.getNombrePosicion();
            txtSalMax.Text = trabajadorAUpdatear.getSueldoMax().ToString();
            txtSalMin.Text = trabajadorAUpdatear.getSueloMin().ToString();
        }

        private void btnAcceptModify_Click(object sender, EventArgs e)
        {
            DALJobs empleoAUpdatear = new DALJobs();
            Job EmpleoUpdateado = new Job(txtPuesto.Text, Convert.ToDouble(txtSalMin.Text), Convert.ToDouble(txtSalMax.Text), trabajadorAUpdatear.getID());
            empleoAUpdatear.modifyJob(EmpleoUpdateado);
            this.Close();
        }
    }
}
