using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Statusbar.VistaModelo;
using Xamarin.Forms;
namespace Statusbar.VistaModelo
{
    public class VMmainpage
    {
        public VMmainpage()
        {
            
        }

        public void Ocultar()
        {
            DependencyService.Get<IVMStatusbar>().OcultarStatusBat();
        }
        public void Mostrar()
        {
            DependencyService.Get<IVMStatusbar>().MostrarStatusBar();
        }
        public void Traslucido()
        {
            DependencyService.Get<IVMStatusbar>().Traslucido();
        }
        public void Transparente()
        {
            DependencyService.Get<IVMStatusbar>().Transparente();
        }
        public void CambiarColor()
        {
            DependencyService.Get<IVMStatusbar>().Cambiarcolor();
        }

        public ICommand OcultarCommand => new Command(Ocultar);
        public ICommand MostrarCommand => new Command(Mostrar);
        public ICommand TraslucidoCommand => new Command(Traslucido);
        public ICommand TransparenteCommand => new Command(Transparente);
        public ICommand CambiarcolorCommand => new Command(CambiarColor);
    }
}
