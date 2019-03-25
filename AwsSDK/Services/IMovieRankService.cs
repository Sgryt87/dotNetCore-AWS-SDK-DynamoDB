using System.Collections.Generic;
using System.Threading.Tasks;
using AwsSDK.Contracts;

namespace AwsSDK.Services
{
    public interface IMovieRankService
    {
        Task<IEnumerable<MovieResponse>> GetAllItemsFromDatabase();

        Task<MovieResponse> GetMovie(int userId, string movieName);

        Task<IEnumerable<MovieResponse>> GetUsersRankedMoviesByMovieTitle(int userId, string movieName);

        Task AddMovie(int userId, MovieRankRequest movieRankRequest);

        Task UpdateMovie(int userId, MovieUpdateRequest movieUpdateRequest);

        Task<MovieRankResponse> GetMovieRank(string movieRank);
    }
}