using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.Sqlite;

namespace IyaInterfaz.Services
{
    public sealed class DbBridge : IDisposable
    {
        private bool _disposed = false;
        private SqliteConnection _connection;

        public DbBridge()
        {
            _connection = new SqliteConnection("Data Source=Iya.db;Mode=ReadWrite");
            _connection.Open();
        }

        public void Dispose()
        {
            if (_disposed) { return; }
            ((IDisposable)_connection).Dispose();
            _disposed = true;
        }
    }
}
