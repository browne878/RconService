namespace Rcon.Core
{
    using System;
    using Rcon.Core.Repositories;

    public interface IUnitOfWork : IDisposable
    {
        IExampleRepository ExampleRepository { get; }
        void Commit();
    }
}
