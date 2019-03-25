using System.Collections.Generic;
using Amazon.DynamoDBv2.DocumentModel;
using AwsSDK.Contracts;

namespace AwsSDK.Libs.Mappers
{
    public interface IMapper
    {
        IEnumerable<MovieResponse> ToMovieContract(IEnumerable<Document> items);
        MovieResponse ToMovieContract(Document item);
        Document ToDocumentModel(int userId, MovieRankRequest movieRankRequest);
        Document ToDocumentModel(int userId, MovieResponse movieResponse, MovieUpdateRequest movieUpdateRequest);
    }
}