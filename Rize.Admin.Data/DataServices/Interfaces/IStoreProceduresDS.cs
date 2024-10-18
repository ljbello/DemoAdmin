using Dapper;

namespace Rize.Admin.Data.DataServices.Interfaces
{
    public interface IStoreProceduresDS
    {
        /// <summary>
        /// Execute a stored procedure
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="ConnectionString"></param>
        /// <param name="param"></param>
        void ExecuteStoredProc(string procedureName, string ConnectionString, DynamicParameters param = null);
        
        /// <summary>
        /// Return a list of objects
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="procedureName"></param>
        /// <param name="ConnectionString"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        
        IEnumerable<T> ExecuteStoredProcList<T>(string procedureName, string ConnectionString, DynamicParameters param = null);


        /// <summary>
        /// Return a tuple of two lists
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="procedureName"></param>
        /// <param name="ConnectionString"></param>
        /// <param name="param"></param>
        /// <returns></returns>

        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedureName, string ConnectionString, DynamicParameters param = null);
        
        /// <summary>
        /// Returns first row
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="procedureName"></param>
        /// <param name="ConnectionString"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        T OneRecord<T>(string procedureName, string ConnectionString, DynamicParameters param = null);
        
        /// <summary>
        /// Returns first column of first row
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="procedureName"></param>
        /// <param name="ConnectionString"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        T Single<T>(string procedureName, string ConnectionString, DynamicParameters param = null);
    }
}
