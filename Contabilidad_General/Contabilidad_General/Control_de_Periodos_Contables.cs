using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Control_de_Periodos_Contables : Gtk.Window
    {
        public Control_de_Periodos_Contables() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();

        }


        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTPeriodo_Contable dta = new Datos.DTPeriodo_Contable();
            List<Entidades.Periodo_contable> lista = new List<Entidades.Periodo_contable>();
            lista = dta.ListarPeriodos_Contables();

            foreach (Entidades.Periodo_contable a in lista)
            {
                ls.AppendValues(a.IdPeriodos_contables.ToString(), a.CodigoPeriodo.ToString(), a.Fecha_inicio.ToString(), a.Fecha_fin.ToString(), a.Activo.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Usuario_idUsuario.ToString());
            }

            //Crear el modelo de datos
            tvPeriodosContables.Model = ls;

            tvPeriodosContables.AppendColumn("idPeriodos_contables", new CellRendererText(), "text", 0);
            tvPeriodosContables.AppendColumn("codigoPeriodo", new CellRendererText(), "text", 1);
            tvPeriodosContables.AppendColumn("fecha_incio", new CellRendererText(), "text", 2);
            tvPeriodosContables.AppendColumn("fecha_fin", new CellRendererText(), "text", 3);
            tvPeriodosContables.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvPeriodosContables.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 5);
            tvPeriodosContables.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);



        }



        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
