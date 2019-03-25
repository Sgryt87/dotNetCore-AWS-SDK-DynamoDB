using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;

namespace AwsSDK.Libs.Repositories
{
    public interface IMovieRankRepository
    {
        Task<IEnumerable<Document>> GetAllItems();
        Task<Document> GetMovie(int userId, string movieName);
        Task<IEnumerable<Document>> GetUsersRankedMoviesByMovieTitle(int userId, string movieName);
        Task AddMovie(Document document);
        Task UpdateMovie(Document document);
        Task<IEnumerable<Document>> GetMovieRank(string movieName);
    }
}