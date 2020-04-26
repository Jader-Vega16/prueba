using System;
namespace Contabilidad_General
{
    public partial class Generar_Empresa : Gtk.Window
    {
        public Generar_Empresa() :
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
