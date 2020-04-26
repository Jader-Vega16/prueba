using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Control_de_Empresa : Gtk.Window
    {

        Mensaje _msj = new Mensaje();
        conexion cn = new conexion();

        public Control_de_Empresa() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();

        }


        ListStore ls = new ListStore( typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTEmpresa dta = new Datos.DTEmpresa();
            List<Entidades.Empresa> lista = new List<Entidades.Empresa>();
            lista = dta.ListarEmpresas();

            foreach (Entidades.Empresa a in lista)
            {
                ls.AppendValues(a.Id_empresa.ToString(), a.Nombre_empresa.ToString(), a.Nombre_comercial.ToString(), a.Nombre_comercial.ToString(), a.Direccion_empresa.ToString(), a.Localidad_empresa.ToString(), a.Correo_empresa.ToString(), a.Activo.ToString());
            }

            //Crear el modelo de datos
            tvEmpresa.Model = ls;

            tvEmpresa.AppendColumn("id_empresa", new CellRendererText(), "text", 0);
            tvEmpresa.AppendColumn("nombre_empresa", new CellRendererText(), "text", 1);
            tvEmpresa.AppendColumn("nombre_comercial", new CellRendererText(), "text", 2);
            tvEmpresa.AppendColumn("direccion_empresa", new CellRendererText(), "text", 3);
            tvEmpresa.AppendColumn("localidad_empresa", new CellRendererText(), "text", 4);
            tvEmpresa.AppendColumn("correo_empresa", new CellRendererText(), "text", 5);
            tvEmpresa.AppendColumn("activo", new CellRendererText(), "text", 6);
  



        }




        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
