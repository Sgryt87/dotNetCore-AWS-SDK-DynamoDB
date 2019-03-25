using System.Threading.Tasks;
using AwsSDK.Services;
using Microsoft.AspNetCore.Mvc;

namespace AwsSDK.Controllers
{
    [Route("setup")]
    public class SetupController : Controller
    {
        private readonly ISetupService _setupService;

        public SetupController(ISetupService setupService)
        {
            _setupService = setupService;
        }

        [HttpPost]
        [Route("createtable/{dynamoDbTableName}")]
        public async Task<IActionResult> CreateDynamoDbTable(string dynamoDbTableName)
        {
            await _setupService.CreateDynamoDbTable(dynamoDbTableName);

            return Ok();
        }

        [HttpDelete]
        [Route("deletetable/{dynamoDbTableName}")]
        public async Task<IActionResult> DeleteDynamoDbTable(string dynamoDbTableName)
        {
            await _setupService.DeleteDynamoDbTable(dynamoDbTableName);

            return Ok();
        }
    }
}