namespace Atalaya.Data
{
    public class ODBCConfiguration
    {

        public ODBCConfiguration(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
    }
}
