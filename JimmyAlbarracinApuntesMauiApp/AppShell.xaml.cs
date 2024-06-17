namespace JimmyAlbarracinApuntesMauiApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(JA_Views.JA_NotePage), typeof(JA_Views.JA_NotePage));

        }
    }
}
