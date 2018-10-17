using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFinalPAv
{
    class Empleado
    {
        string sNombre { get; set; }
        int iEdad { get; set; }
        int iDUI { get; set; }

        public Empleado()
        {
            sNombre = null;
            iEdad = 0;
            iDUI = 0;
        }

        public virtual void MostrarDatos()
        {
            System.Windows.Forms.MessageBox.Show(
                "Nombre: " + sNombre +
                "\nEdad: " + iEdad.ToString() +
                "\nDUI: " + iDUI.ToString()
                );
        }

        public virtual double CalcularSalario()
        {
            int iHorasMes = 0;
            double dPrecioHora = 0;
            double dSueldo = 0;
            double dBaseMensual = 0;
            double dComplementoAnual = 0;
            int iAnniosEnLaEmpresa = 0;


            return dSueldo;
        }

    }

    class EmpleadoTemporal : Empleado
    {
        DateTime dtFechaIngreso { get; set; }
        DateTime dtFechaSalida { get; set; }
        double dSalario { get; set; }

        public EmpleadoTemporal()
        {
            dtFechaIngreso = new DateTime();
            dtFechaSalida = new DateTime();
            dSalario = 0;
        }

        public override double CalcularSalario()
        {
            return this.dSalario;
        }
    }

    class EmpleadoPorHoras : Empleado
    {
        double dPrecioHora { get; set; }
        int iHorasMes { get; set; }

        public EmpleadoPorHoras()
        {
            dPrecioHora = 0;
            iHorasMes = 0;
        }

        public override double CalcularSalario()
        {
            return dPrecioHora * iHorasMes;
        }
    }

    class EmpleadoFijo : Empleado
    {
        DateTime dtFechaDeAlta_year { get; set; }
        double dBaseMensual { get; set; }
        double dComplementoAnual { get; set; }
        double iAnniosEnLaEmpresa { get; set; }

        public EmpleadoFijo()
        {
            this.dtFechaDeAlta_year = new DateTime();
            this.dBaseMensual = 0;
            this.dComplementoAnual = 0;
            this.dComplementoAnual = 0;
        }

        public override double CalcularSalario()
        {
            return (this.dBaseMensual + this.dComplementoAnual) * this.dComplementoAnual;
        }
    }
}
