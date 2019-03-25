using System;
using System.Collections.Generic;
using System.Linq;
using AwsSDK.Contracts;
using AwsSDK.Libs.Models;

namespace AwsSDK.Libs.Mappers
{
    public class Mapper : IMapper
    {
        public IEnumerable<MovieResponse> ToMovieContract(IEnumerable<MovieDb> items)
        {
            return items.Select(ToMovieContract);
        }

        public MovieResponse ToMovieContract(MovieDb movie)
        {
            return new MovieResponse()
            {
                MovieName = movie.MovieName,
                Description = movie.Description,
                Actors = movie.Actors,
                Ranking = movie.Ranking,
                TimeRanked = movie.RankedDateTime
            };
        }

        public MovieDb ToMovieDbModel(int userId, MovieRankRequest movieRankRequest)
        {
            return new MovieDb()
            {
                UserId = userId,
                MovieName = movieRankRequest.MovieName,
                Description = movieRankRequest.Description,
                Actors = movieRankRequest.Actors,
                Ranking = movieRankRequest.Ranking,
                RankedDateTime = DateTime.UtcNow.ToString()
            };
        }

        // overload method
        public MovieDb ToMovieDbModel(int userId, MovieDb movieDb, MovieUpdateRequest movieUpdateRequest)
        {
            return new MovieDb()
            {
                UserId = movieDb.UserId,
                MovieName = movieDb.MovieName,
                Description = movieDb.Description,
                Actors = movieDb.Actors,
                Ranking = movieUpdateRequest.Ranking,
                RankedDateTime = DateTime.UtcNow.ToString()
            };
        }
    }
}