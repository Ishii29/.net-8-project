using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;
using Project.Core;

namespace Project.Data
{
    public class ProgramRepository : IProgrmRepository
    {
        private readonly CosmosClient cosmosClient;
        private readonly IConfiguration configuration;
        private readonly Container _programContainer;

        public ProgramRepository(CosmosClient cosmosClient, IConfiguration configuration)
        {
            this.cosmosClient = cosmosClient;
            this.configuration = configuration;
            var databaseName = configuration["CosmosDbSettings : DatabaseName"];
            var programContainerName = "Program";
            _programContainer = cosmosClient.GetContainer(databaseName, programContainerName);
        }
        public async Task<IEnumerable<Programs>> GetProgramsAsync(string employerID)
        {
            var query = _programContainer.GetItemLinqQueryable<Programs>()
                .Where(t => t.Equals(employerID))
                .ToFeedIterator();
            var program = new List<Programs>();

            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                program.AddRange(response);
            }
            return program;
        }
    }
}