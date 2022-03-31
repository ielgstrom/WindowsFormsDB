using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsDB.DAL
{
    class DALJobs
    {
        InitializerDB initDB = null;
        public DALJobs()
        {
             initDB = new InitializerDB();
        }
         public List<Job> getListJobs( List<Job> listaTrabajos)
        {
            string cadena = "SELECT * FROM JOBS";
            SqlCommand cmd = new SqlCommand(cadena, initDB.connectionReturn());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTrabajos.Add(new Job(dr[1].ToString(), Convert.ToDouble(dr[2]), Convert.ToDouble(dr[3]), Convert.ToInt32(dr[0])));
            }
            dr.Close();
            return listaTrabajos;
        }

        public void AddJob(string nombrePosicion, double sueldo_min, double sueldo_max)
        {
            try
            { 
            string sql = @"
                        INSERT INTO jobs
                        VALUES('" + nombrePosicion + "'," + sueldo_min + ", " + sueldo_max + ")";
            SqlCommand cmd = new SqlCommand(sql, initDB.connectionReturn());
            cmd.ExecuteNonQuery();
            }
            catch(Exception rt)
            {
                MessageBox.Show("Error al insertar: " + rt);
            }
        }
        public void delteJob(int job_id)
        {
            string sql = @"
                        delete from jobs
                        where job_id=" + job_id;
            SqlCommand cmd = new SqlCommand(sql, initDB.connectionReturn());
            cmd.ExecuteNonQuery();
        }
        public void modifyJob(string nombrePuesto, double salMin, double salMax, int id_job)
        {
            string sql = @"
                        UPDATE jobs
                        SET job_title=" +"'"+nombrePuesto+"'"+", min_salary="+"'"+salMin+"'" + ", max_salary=" + "'" + salMax + "'" +
                        "where job_id=" + id_job;
            SqlCommand cmd = new SqlCommand(sql, initDB.connectionReturn());
            cmd.ExecuteNonQuery();
        }
    }
}
