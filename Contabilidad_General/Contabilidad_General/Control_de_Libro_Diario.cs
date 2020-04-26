using System;
namespace Contabilidad_General
{
    public partial class Control_de_Libro_Diario : Gtk.Window
    {
        public Control_de_Libro_Diario() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
