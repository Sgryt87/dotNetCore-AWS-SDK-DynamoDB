using System.Threading.Tasks;

namespace AwsSDK.Services
{
    public interface ISetupService
    {
        Task CreateDynamoDbTable(string dynamoDbTableName);
        Task DeleteDynamoDbTable(string dynamoDbTableName);
    }
}