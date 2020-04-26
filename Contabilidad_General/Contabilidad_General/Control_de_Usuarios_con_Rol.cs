using System;
namespace Contabilidad_General
{
    public partial class Control_de_Usuarios_con_Rol : Gtk.Window
    {
        public Control_de_Usuarios_con_Rol() :
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
