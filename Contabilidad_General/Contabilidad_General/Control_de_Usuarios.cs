using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;


namespace Contabilidad_General
{
    public partial class Control_de_Usuarios : Gtk.Window
    {

        Mensaje _msj = new Mensaje();
        conexion cn = new conexion();


        public Control_de_Usuarios() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();



        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTUsuario dta = new Datos.DTUsuario();
            List<Entidades.Usuario> lista = new List<Entidades.Usuario>();
            lista = dta.ListarUsuarios();

            foreach (Entidades.Usuario a in lista)
            {
                ls.AppendValues(a.IdUsuario.ToString(), a.Usuario_.ToString(), a.Pwd.ToString(), a.FechaCreacion.ToString(), a.Activo.ToString(), a.Empleados_idEmpleado.ToString(), a.Detalles_empresa_id_empresa.ToString());
            }

            //Crear el modelo de datos
            tvUsuarios.Model = ls;

            tvUsuarios.AppendColumn("idUsuario", new CellRendererText(), "text", 0);
            tvUsuarios.AppendColumn("usuario", new CellRendererText(), "text", 1);
            tvUsuarios.AppendColumn("pwd", new CellRendererText(), "text", 2);
            tvUsuarios.AppendColumn("fechaCreacion", new CellRendererText(), "text", 3);
            tvUsuarios.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvUsuarios.AppendColumn("Empleados_idEmpleado", new CellRendererText(), "text", 5);
            tvUsuarios.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 6);



        }






        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
