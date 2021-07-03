namespace Rcon.Data.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;
    using Rcon.Core.Entities;
    using Rcon.Core.Repositories;

    internal class ExampleRepository : RepositoryBase, IExampleRepository
    {
        public ExampleRepository(IDbTransaction _transaction) : base(_transaction)
        {

        }

        public async Task AddAsync(Example _entity)
        {
            const string sql = @"INSERT INTO example_table (Name, Description) Values (@Name, @Description)";

            await ExecuteAsync(sql, _entity);
        }

        public async Task<IEnumerable<Example>> GetAllAsync()
        {
            const string sql = "SELECT * FROM example_table";

            return await QueryAsync<Example>(sql);
        }

        public async Task<Example> GetAsync(string _key)
        {
            const string sql = "SELECT * FROM example_table WHERE id = @Key";
            var param = new { Key = _key };

            return await QueryFirstOrDefaultAsync<Example>(sql, param);
        }

        public async Task<Example> FindByNameAsync(string _exampleName)
        {
            const string sql = "SELECT * FROM example_table WHERE name = @Name";
            var param = new { Name = _exampleName };

            return await QueryFirstOrDefaultAsync<Example>(sql, param);
        }

        public async Task RemoveAsync(string _key)
        {
            const string sql = "DELETE FROM example_table WHERE id = @Key";
            var param = new { Key = _key };

            await ExecuteAsync(sql, param);
        }

        public async Task UpdateAsync(Example _entity)
        {
            const string sql = @"UPDATE example_table SET name = @name, description = @Description WHERE id = @Id";

            await ExecuteAsync(sql, _entity);
        }
    }
}
