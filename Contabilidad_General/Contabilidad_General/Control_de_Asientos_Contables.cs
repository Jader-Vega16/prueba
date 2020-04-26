using System;
namespace Contabilidad_General
{
    public partial class Control_de_Asientos_Contables : Gtk.Window
    {
        public Control_de_Asientos_Contables() :
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
