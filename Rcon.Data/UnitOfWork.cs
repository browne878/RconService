namespace Rcon.Data
{
    using System;
    using System.Data;
    using Npgsql;
    using Rcon.Core;
    using Rcon.Core.Entities;
    using Rcon.Core.Repositories;
    using Rcon.Data.Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        private IDbConnection connection;
        private IDbTransaction transaction;
        private IExampleRepository exampleRepository;
        private bool disposed;
          
        public UnitOfWork(BaseConfig _config)
        {
            connection = new NpgsqlConnection(_config.Connection.GetConnectionString());
            connection.Open();
            transaction = connection.BeginTransaction();
        }

        public IExampleRepository ExampleRepository => exampleRepository ??= new ExampleRepository(transaction);

        public void Commit()
        {
            try
            {
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
                ResetRepositories();
                transaction = connection.BeginTransaction();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #region Private Methods
        private void ResetRepositories()
        {
            exampleRepository = null;
        }

        private void Dispose(bool _disposing)
        {
            if (!disposed)
            {
                if (_disposing)
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                        transaction = null;
                    }
                    if (connection != null)
                    {
                        connection.Dispose();
                        connection = null;
                    }
                }
                disposed = true;
            }
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}
