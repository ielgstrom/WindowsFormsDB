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
        private int job_id;
        public Job(string nombrePosicion, double sueldo_min, double sueldo_max)
        {
            this.sueldo_max = sueldo_max;
            this.sueldo_min = sueldo_min;
            this.nombrePosicion = nombrePosicion;
        }
        public Job(string nombrePosicion, double sueldo_min, double sueldo_max, int job_id)
        {
            this.sueldo_max = sueldo_max;
            this.sueldo_min = sueldo_min;
            this.nombrePosicion = nombrePosicion;
            this.job_id = job_id;
        }
        public string getNombrePosicion() { return nombrePosicion; }
        public double getSueloMin() { return sueldo_min; }
        public double getSueldoMax() { return sueldo_max; }
        public void setNombrePosicion(string newPosicion) { nombrePosicion = newPosicion; }
        public void setMin(double newMax) { sueldo_min = newMax; }
        public void setMax(double newMin) { sueldo_max = newMin; }
        public int getID() { return job_id; }

        public override string ToString()
        {
            return "("+job_id.ToString()+") "+ nombrePosicion.ToString() + " tiene sueldo minimo de " + sueldo_min.ToString() + "€ y maximo de " + sueldo_max.ToString() + "€";
        }



    }
}
