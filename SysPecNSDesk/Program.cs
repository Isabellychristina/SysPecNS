using SysPecNSLib;

namespace SysPecNSDesk
{
    internal static class Program
    {
        // criar propriedade estatica do tipo usuario
        public static Usuario UsuarioLogado = null;
        
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmPrincipal());
            //Application.Run(New FrmLogin());
        }
    }
}