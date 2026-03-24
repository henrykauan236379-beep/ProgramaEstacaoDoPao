using System.Configuration;
using System.Data.Common;

namespace ProgramaPadaria

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DbConnection con = null;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new fFormInicial());
            string conexao =
                ConfigurationManager.ConnectionStrings["sistema_padaria"].ConnectionString;
            using Npgsql.NpgsqlConnection conn = new Npgsql.NpgsqlConnection(conexao);
            conn.Open();
            MessageBox.Show("Conexão com o banco de dados estabelecida com sucesso!");
        }
    }
}