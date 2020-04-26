using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Control_de_Catalogo_de_Cuentas : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
        conexion cn = new conexion();

        public Control_de_Catalogo_de_Cuentas() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();


        }

        ListStore ls = new ListStore( typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTCatalogoCuentas dta = new Datos.DTCatalogoCuentas();
            List<Entidades.Catalogo_de_cuenta> lista = new List<Entidades.Catalogo_de_cuenta>();
            lista = dta.ListarCatalogo();

            foreach (Entidades.Catalogo_de_cuenta a in lista)
            {
                ls.AppendValues(a.IdCatalogo_cuentas.ToString(), a.Numero_cuenta.ToString(), a.Nombre_cuenta.ToString(), a.Descripcion_cuenta.ToString(), a.Activo.ToString(), a.Pais_cuenta.ToString(), a.Id_cuentaPadre.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Tipos_naturaleza_id_naturalezaCuenta.ToString(), a.Usuario_idUsuario.ToString());
            }

            //Crear el modelo de datos
            tvCatalogoCuentas.Model = ls;

            tvCatalogoCuentas.AppendColumn("idCatalogo_cuentas", new CellRendererText(), "text", 0);
            tvCatalogoCuentas.AppendColumn("numero_cuenta", new CellRendererText(), "text", 1);
            tvCatalogoCuentas.AppendColumn("nombre_cuenta", new CellRendererText(), "text", 2);
            tvCatalogoCuentas.AppendColumn("descripcion_cuenta", new CellRendererText(), "text", 3);
            tvCatalogoCuentas.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvCatalogoCuentas.AppendColumn("pais_cuenta", new CellRendererText(), "text", 5);
            tvCatalogoCuentas.AppendColumn("id_cuentaPadre", new CellRendererText(), "text", 6);
            tvCatalogoCuentas.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);
            tvCatalogoCuentas.AppendColumn("Tipos_naturaleza_id_naturalezaCuenta", new CellRendererText(), "text", 8);
            tvCatalogoCuentas.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 9);




        }






        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
