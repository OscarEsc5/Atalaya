using Atalaya.Model;
using System.Data.Odbc;

namespace Atalaya.Data.Repositories
{
    public class SAPBusinessPartnersRepository : ISAPBusinessPartnersRepository
    {
        private readonly ODBCConfiguration _connectionString;

        public SAPBusinessPartnersRepository(ODBCConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected OdbcConnection dbConnection()
        {
            return new OdbcConnection(_connectionString.ConnectionString);
        }

        public Task<Response> UpdateBusinessPartner(SAPBusinessParter sAPBusinessParter)
        {
            Response respUpdateBusinessPartner = new Response();
            respUpdateBusinessPartner.conflicts = new List<Conflicts>();

            throw new NotImplementedException();
        }
    }
}
