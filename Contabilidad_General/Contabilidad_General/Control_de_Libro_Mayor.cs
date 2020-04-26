using System;
namespace Contabilidad_General
{
    public partial class Control_de_Libro_Mayor : Gtk.Window
    {
        public Control_de_Libro_Mayor() :
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
