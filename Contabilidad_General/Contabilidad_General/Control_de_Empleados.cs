using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Control_de_Empleados : Gtk.Window
    {


        Mensaje _msj = new Mensaje();
        conexion cn = new conexion();

        public Control_de_Empleados() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            llenarTreeview();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String),typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTEmpleados dta = new Datos.DTEmpleados();
            List<Entidades.Empleado> lista = new List<Entidades.Empleado>();
            lista = dta.ListarEmpleados();

            foreach (Entidades.Empleado a in lista)
            {
                ls.AppendValues(a.IdEmpleado.ToString(), a.Fecha_ingreso.ToString(), a.Cedula.ToString() ,a.Nombre_cargo.ToString(), a.Nombre_empleado.ToString(),a.Apellido_empleado.ToString(),a.Telefono_empleado.ToString(),a.Celular_empleado.ToString(),a.Correo_empleado.ToString(),a.Direccion_empleado.ToString(),a.Sueldo.ToString(),a.Activo.ToString());
            }

            //Crear el modelo de datos
            tvEmpleados.Model = ls;

            tvEmpleados.AppendColumn("idEmpleado", new CellRendererText(), "text", 0);
            tvEmpleados.AppendColumn("fecha_ingreso", new CellRendererText(), "text", 1);
            tvEmpleados.AppendColumn("cedula", new CellRendererText(), "text", 2);
            tvEmpleados.AppendColumn("nombre_cargo", new CellRendererText(), "text", 3);
            tvEmpleados.AppendColumn("nombre_empleado", new CellRendererText(), "text", 4);
            tvEmpleados.AppendColumn("apellido_empleado", new CellRendererText(), "text", 5);
            tvEmpleados.AppendColumn("telefono_empleado", new CellRendererText(), "text", 6);
            tvEmpleados.AppendColumn("celular_empleado", new CellRendererText(), "text", 7);
            tvEmpleados.AppendColumn("correo_empleado", new CellRendererText(), "text", 8);
            tvEmpleados.AppendColumn("direccion_empleado", new CellRendererText(), "text", 9);
            tvEmpleados.AppendColumn("sueldo", new CellRendererText(), "text", 10);
            tvEmpleados.AppendColumn("activo", new CellRendererText(), "text", 11);



        }




        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
