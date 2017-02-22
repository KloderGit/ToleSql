using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace ToleSql.Dapper
{
    public static class QueryAsyncSelectFromExtensions
    {
        public static Task<IEnumerable<dynamic>> QueryAsync(this IDbConnection cnn, SelectFrom builder,
            IDbTransaction transaction = null, int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return cnn.QueryAsync(builder.Builder.GetSqlText(), builder.Builder.Parameters, transaction, commandTimeout, commandType);
        }
        public static Task<IEnumerable<object>> Query(this IDbConnection cnn, Type type, SelectFrom builder,
            IDbTransaction transaction = null, int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return cnn.QueryAsync(type, builder.Builder.GetSqlText(), builder.Builder.Parameters, transaction, commandTimeout, commandType);
        }
        public static Task<IEnumerable<T>> Query<T>(this IDbConnection cnn, SelectFrom builder, SqlTransaction transaction = null,
            int? commandTimeout = 0, CommandType? commandType = null)
        {
            return cnn.QueryAsync<T>(builder.Builder.GetSqlText(), builder.Builder.Parameters, transaction, commandTimeout, commandType);
        }
        public static Task<IEnumerable<TReturn>> Query<TReturn>(this IDbConnection cnn, SelectFrom builder,
            Type[] types, Func<object[], TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return cnn.QueryAsync<TReturn>(builder.Builder.GetSqlText(), types, map, builder.Builder.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }
        public static Task<IEnumerable<TReturn>> Query<TFirst, TSecond, TReturn>(this IDbConnection cnn, SelectFrom builder,
            Func<TFirst, TSecond, TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return cnn.QueryAsync(builder.Builder.GetSqlText(), map, builder.Builder.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }
        public static Task<IEnumerable<TReturn>> Query<TFirst, TSecond, TThird, TReturn>(this IDbConnection cnn, SelectFrom builder,
            Func<TFirst, TSecond, TThird, TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return cnn.QueryAsync(builder.Builder.GetSqlText(), map, builder.Builder.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }
        public static Task<IEnumerable<TReturn>> Query<TFirst, TSecond, TThird, TFourth, TReturn>(this IDbConnection cnn, SelectFrom builder,
            Func<TFirst, TSecond, TThird, TFourth, TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return cnn.QueryAsync(builder.Builder.GetSqlText(), map, builder.Builder.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }
        public static Task<IEnumerable<TReturn>> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this IDbConnection cnn, SelectFrom builder,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return cnn.QueryAsync(builder.Builder.GetSqlText(), map, builder.Builder.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }
        public static Task<IEnumerable<TReturn>> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this IDbConnection cnn, SelectFrom builder,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return cnn.QueryAsync(builder.Builder.GetSqlText(), map, builder.Builder.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }
        public static Task<IEnumerable<TReturn>> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this IDbConnection cnn, SelectFrom builder,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return cnn.QueryAsync(builder.Builder.GetSqlText(), map, builder.Builder.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }
    }
}