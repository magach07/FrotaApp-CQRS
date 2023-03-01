using System.Data;
using Microsoft.Data.SqlClient;

namespace FrotaApp.Infrastructure.Shared.Factory
{
    public class SqlFactory
    {
        public IDbConnection SqlConnection()
        {
            return new SqlConnection("Server=desktop-n3ub7sm;DataBase=BANCO_FROTA;User=sa;Password=windowslinuxj;Trusted_Connection=false;TrustServerCertificate=True;");
        }
    }
}