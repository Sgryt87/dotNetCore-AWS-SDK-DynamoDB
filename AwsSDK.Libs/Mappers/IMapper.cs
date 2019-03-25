using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2.Model;
using AwsSDK.Contracts;
using AwsSDK.Libs.Models;

namespace AwsSDK.Libs.Mappers
{
    public interface IMapper
    {
        IEnumerable<MovieResponse> ToMovieContract(ScanResponse response);
        IEnumerable<MovieResponse> ToMovieContract(QueryResponse response);
        MovieResponse ToMovieContract(GetItemResponse response);
    }
}