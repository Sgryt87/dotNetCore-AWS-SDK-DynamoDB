using System.Collections.Generic;
using System.Linq;
using AwsSDK.Contracts;
using AwsSDK.Libs.Models;

namespace AwsSDK.Libs.Mappers
{
    public interface IMapper
    {
        IEnumerable<MovieResponse> ToMovieContract(IEnumerable<MovieDb> items);
        MovieResponse ToMovieContract(MovieDb movie);
        MovieDb ToMovieDbModel(int userId, MovieRankRequest movieRankRequest);
        MovieDb ToMovieDbModel(int userId, MovieDb movieDb, MovieUpdateRequest movieUpdateRequest);
    }
}