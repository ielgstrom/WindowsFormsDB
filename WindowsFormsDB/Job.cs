using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsDB
{
    class Job
    {
        private string nombrePosicion;
        private double sueldo_min;
        private double sueldo_max;
        public Job(string nombrePosicion, double sueldo_min, double sueldo_max)
        {
            this.sueldo_max = sueldo_max;
            this.sueldo_min = sueldo_min;
            this.nombrePosicion = nombrePosicion;
        }
        public string getNombrePosicion() { return nombrePosicion; }
        public double getSueloMin() { return sueldo_min; }
        public double getSueldoMax() { return sueldo_max; }
        public void setNombrePosicion(string newPosicion) { nombrePosicion = newPosicion; }
        public void setMin(double newMax) { sueldo_min = newMax; }
        public void setMax(double newMin) { sueldo_max = newMin; }

        public void insertIntoDB(SqlConnection conexion)
        {
            string sql = @"
                        INSERT INTO jobs
                        VALUES('" + nombrePosicion + "'," + sueldo_min + ", 0" + sueldo_max + ")";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.ExecuteNonQuery();
        }
        public void delteFromDB(SqlConnection conexion, string nombreAEliminar)
        {
            string sql = @"
                        delete from jobs
                        where job_title="+nombreAEliminar;
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.ExecuteNonQuery();
        }




    }
}
