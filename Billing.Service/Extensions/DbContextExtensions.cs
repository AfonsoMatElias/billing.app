using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Billing.Service.Extensions
{
    public static class DbContextExtensions
    {
        public static async Task ExecuteAsync(this DbContext context, string sql, Action<System.Data.Common.DbDataReader> action = null)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                command.CommandTimeout = 3600;
                context.Database.OpenConnection();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (action == null) return;

                    while (await reader.ReadAsync())
                        action.Invoke(reader);
                }
            }
        }

        public static void Execute(this DbContext context, string sql, Action<System.Data.Common.DbDataReader> action = null)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                command.CommandTimeout = 3600;
                context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    if (action == null) return;

                    while (reader.Read())
                        action.Invoke(reader);
                }
            }
        }

        public static async Task<List<IDictionary<string, object>>> ExecuteAsync(this DbContext context, string sql)
        {
            var data = new List<IDictionary<string, object>>();
            var conn = context.Database.GetDbConnection();

            using (var command = conn.CreateCommand())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    await conn.OpenAsync();

                command.CommandText = sql;
                command.CommandTimeout = 3600;
                command.CommandType = System.Data.CommandType.Text;
                var reader = await command.ExecuteReaderAsync();
                var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();

                while (await reader.ReadAsync())
                {
                    dynamic obj = new Dictionary<string, object>();
                    foreach (var name in columns)
                        obj.Add(name, reader[name]);

                    data.Add(obj);
                }

                if (conn.State == System.Data.ConnectionState.Open)
                    await conn.CloseAsync();
            }

            return data;
        }
    }
}