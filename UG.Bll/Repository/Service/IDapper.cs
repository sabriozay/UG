using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace UG.Bll.Repository.Service
{
    public interface IDapper : IDisposable
    {
        public DbConnection GetDbconnection();
        public T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        public List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        public int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        public T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        public T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
    }
}
