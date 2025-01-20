using ExamenHansOrtiz.Views;

namespace ExamenHansOrtiz
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registrar las rutas de navegación
            Routing.RegisterRoute("HO_CalleDetailPage", typeof(HO_CalleDetailPage));
        }
    }
}