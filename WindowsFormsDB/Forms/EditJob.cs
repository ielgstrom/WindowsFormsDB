using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            txtSalMin.Text = trabajadorAUpdatear.getSueloMin().ToString(); ;

        }

        private void btnAcceptModify_Click(object sender, EventArgs e)
        {
            SqlConnection connxion = new SqlConnection("Data Source=217.71.207.123,54321;Initial Catalog=Ignasi_Employees;Persist Security Info=True;User ID=sa;Password=123456789");
            connxion.Open();
            DALJobs empleoAUpdatear = new DALJobs();
            empleoAUpdatear.modifyJob(txtPuesto.Text, Convert.ToDouble(txtSalMin.Text), Convert.ToDouble(txtSalMax.Text), trabajadorAUpdatear.getID());
            this.Close();
        }
    }
}
