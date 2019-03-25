using System.Collections.Generic;
using System.Threading.Tasks;
using AwsSDK.Libs.Models;

namespace AwsSDK.Libs.Repositories
{
    public interface IMovieRankRepository
    {
        Task<IEnumerable<MovieDb>> GetAllItems();

        Task<MovieDb> GetMovie(int userId, string movieName);

        Task<IEnumerable<MovieDb>> GetUsersRankedMoviesByMovieTitle(int userId, string movieName);

        Task AddMovie(MovieDb movieDb);

        Task UpdateMovie(MovieDb movieDb);

        Task<IEnumerable<MovieDb>> GetMovieRank(string movieName);
    }
}