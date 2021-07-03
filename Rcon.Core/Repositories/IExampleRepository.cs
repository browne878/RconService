namespace Rcon.Core.Repositories
{
    using System.Threading.Tasks;
    using Rcon.Core.Entities;

    public interface IExampleRepository : IBaseRepository<Example, string>
    {
        Task<Example> FindByNameAsync(string _exampleName);
    }
}
