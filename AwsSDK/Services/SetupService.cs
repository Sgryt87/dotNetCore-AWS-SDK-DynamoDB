using System.Threading.Tasks;
using AwsSDK.Libs.Repositories;

namespace AwsSDK.Services
{
    public class SetupService : ISetupService
    {
        private readonly IMovieRankRepository _movieRankRepository;

        public SetupService(IMovieRankRepository movieRankRepository)
        {
            _movieRankRepository = movieRankRepository;
        }

        public async Task CreateDynamoDbTable(string dynamoDbTableName)
        {
            await _movieRankRepository.CreateDynamoDbTable(dynamoDbTableName);
        }

        public async Task DeleteDynamoDbTable(string dynamoDbTableName)
        {
            await _movieRankRepository.DeleteDynamoDbTable(dynamoDbTableName);
        }
    }
}