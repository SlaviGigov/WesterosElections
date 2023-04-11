using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WesterosElections.MyServices;

namespace WesterosElections.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataAccessController : ControllerBase
    {
        private readonly IMyDataActions dataActions;
        public DataAccessController(IMyDataActions dataActions)
        {
            this.dataActions = dataActions;
        }


        [HttpPost(nameof(AddNewTribe))]
        public IMyDataActions AddNewTribe(string name)
        {
            var rowsAffected = this.dataActions.AddNewTribe(name);
            return (IMyDataActions)Ok(rowsAffected);
        }


        [HttpPost(nameof(AddNewRegion))]
        public IMyDataActions AddNewRegion(string name)
        {
            var rowsAffected = this.dataActions.AddNewRegion(name);
            return (IMyDataActions)Ok(rowsAffected);
        }


        [HttpDelete(nameof(DeleteTribe))]
        public IActionResult DeleteTribe(string name)
        {
            var deletedRows = this.dataActions.DeleteTribe(name);
            return Ok(new { deletedRows });
        }


        [HttpDelete(nameof(DeleteRegion))]
        public IActionResult DeleteRegion(string name)
        {
            var deletedRows = this.dataActions.DeleteRegion(name);
            return Ok(new { deletedRows });
        }


        [HttpGet(nameof(GetAllRegionsResult))]
        public IActionResult GetAllRegionsResult()
        {
            var data = this.dataActions.GetAllRegionsResult();
            return Ok(data);
        }


        [HttpGet(nameof(GetAllTribesResult))]
        public IActionResult GetAllTribesResult()
        {
            var data = this.dataActions.GetAllTribesResult();
            return Ok(data);
        }

        [HttpGet(nameof(GetVoteByRegion))]
        public IActionResult GetVoteByRegion(string name)
        {
            var data = this.dataActions.GetVoteByRegion(name);
            return Ok(data);
        }


        [HttpGet(nameof(GetVoteByTribe))]
        public IActionResult GetVoteByTribe(string name)
        {
            var data = this.dataActions.GetVoteByTribe(name);
            return Ok(data);
        }


    }
}
