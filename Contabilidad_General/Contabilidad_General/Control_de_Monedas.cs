using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Control_de_Monedas : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
        conexion cn = new conexion();



        public Control_de_Monedas() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();


        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTMoneda dta = new Datos.DTMoneda();
            List<Entidades.Moneda> lista = new List<Entidades.Moneda>();
            lista = dta.ListarMonedas();

            foreach (Entidades.Moneda a in lista)
            {
                ls.AppendValues(a.Id_moneda.ToString(), a.Nombre_moneda.ToString(), a.Codigo_ISO_Alfab.ToString(), a.Pais.ToString(), a.Tasa_conversion.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString());
            }

            //Crear el modelo de datos
            tvMonedas.Model = ls;

            tvMonedas.AppendColumn("id_moneda", new CellRendererText(), "text", 0);
            tvMonedas.AppendColumn("nombre_moneda", new CellRendererText(), "text", 1);
            tvMonedas.AppendColumn("cod_ISO_Alfab", new CellRendererText(), "text", 2);
            tvMonedas.AppendColumn("pais", new CellRendererText(), "text", 3);
            tvMonedas.AppendColumn("tasa_conversion", new CellRendererText(), "text", 4);
            tvMonedas.AppendColumn("activo", new CellRendererText(), "text", 5);
            tvMonedas.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);
            tvMonedas.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);




        }










        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
