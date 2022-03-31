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
         public List<Job> getListJobs()
        {
            List<Job> listaTrabajos = new List<Job>();
            string cadena = "SELECT * FROM JOBS";
            SqlCommand cmd = new SqlCommand(cadena, initDB.Connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTrabajos.Add(new Job(dr[1].ToString(), Convert.ToDouble(dr[2]), Convert.ToDouble(dr[3]), Convert.ToInt32(dr[0])));
            }
            dr.Close();
            return listaTrabajos;
        }

        public void AddJob(Job trabajoNuevo)
        {
            try
            {
                string sql = @"
                        INSERT INTO jobs
                        VALUES(@pPuesto,@pSalarioMin,@pSalarioMax)";
                SqlCommand cmd = new SqlCommand(sql, initDB.Connection);
                SqlParameter pPuesto = new SqlParameter("@pPuesto", System.Data.SqlDbType.VarChar, 35);
                pPuesto.Value = trabajoNuevo.getNombrePosicion();
                SqlParameter pSalarioMin = new SqlParameter("@pSalarioMin", trabajoNuevo.getSueloMin());
                SqlParameter pSalarioMax = new SqlParameter("@pSalarioMax", trabajoNuevo.getSueldoMax());
                cmd.Parameters.Add(pPuesto);
                cmd.Parameters.Add(pSalarioMax);
                cmd.Parameters.Add(pSalarioMin);
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
            SqlCommand cmd = new SqlCommand(sql, initDB.Connection);
            cmd.ExecuteNonQuery();
        }
        public void modifyJob(Job empleado)
        {
            string sql = @"
                        UPDATE jobs
                        SET job_title=@pJobTitle, min_salary=@minSalary, max_salary=@maxSalary
                        where job_id=" + empleado.getID();
            SqlCommand cmd = new SqlCommand(sql, initDB.Connection);
            SqlParameter pSalarioMin = new SqlParameter("@minSalary", empleado.getSueloMin());
            SqlParameter pSalarioMax = new SqlParameter("@maxSalary", empleado.getSueldoMax());
            SqlParameter pPuesto = new SqlParameter("@pJobTitle", System.Data.SqlDbType.VarChar, 35);
            pPuesto.Value = empleado.getNombrePosicion();
            cmd.Parameters.Add(pPuesto);
            cmd.Parameters.Add(pSalarioMin);
            cmd.Parameters.Add(pSalarioMax);
            cmd.ExecuteNonQuery();
        }
    }
}
