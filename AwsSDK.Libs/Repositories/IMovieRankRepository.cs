using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.Model;
using AwsSDK.Contracts;
using AwsSDK.Libs.Models;

namespace AwsSDK.Libs.Repositories
{
    public interface IMovieRankRepository
    {
        Task<ScanResponse> GetAllItems();
        Task<GetItemResponse> GetMovie(int userId, string movieName);
        Task<QueryResponse> GetUsersRankedMoviesByMovieTitle(int userId, string movieName);
        Task AddMovie(int userId, MovieRankRequest movieRankRequest);
        Task UpdateMovie(int userId, MovieUpdateRequest updateRequest);
        Task<QueryResponse> GetMovieRank(string movieName);
        Task CreateDynamoDbTable(string tableName);
        Task DeleteDynamoDbTable(string dynamoDbTableName);
    }
}