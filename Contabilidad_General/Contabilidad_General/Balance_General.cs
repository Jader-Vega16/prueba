using System;
namespace Contabilidad_General
{
    public partial class Balance_General : Gtk.Window
    {
        public Balance_General() :
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
