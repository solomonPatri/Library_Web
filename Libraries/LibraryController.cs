using Library_Web.Libraries.Dtos;
using Library_Web.Libraries.Model;
using Library_Web.Libraries.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.ComTypes;

namespace Library_Web.Libraries
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class LibraryController:ControllerBase
    {

        private ILibraryRepo _libraryRepo;

        public LibraryController(ILibraryRepo libRepo)
        {

            this._libraryRepo = libRepo;

        }


        [HttpGet("all")]

        public async Task<ActionResult<IEnumerable<Library>>> GetAllAsync()
        {

            var lib = await _libraryRepo.GetAllAsync();

            return Ok(lib);

        }

        [HttpPost("create")]

        public async Task<ActionResult<LibraryResponse>>   CreateAsync([FromBody]LibraryRequest createRequest)
        {

            LibraryResponse create = await _libraryRepo.CreateAsync(createRequest);

            return Created("", create);




        }

        [HttpDelete("delete/{id}")]

        public async Task<ActionResult<LibraryResponse>> DeleteAsync([FromRoute]int id)
        {
            LibraryResponse response = await _libraryRepo.DeleteAsync(id);
            return Accepted("", response);


        }


        [HttpPut("edit/{id}")]


        public async Task<ActionResult<LibraryResponse>> UpdateAsync([FromRoute]int id, [FromBody] LibraryUpdateRequest update)
        {


            LibraryResponse response = await _libraryRepo.UpdateAsync(id, update);

            return Accepted(" ", response);




        }
























    }
}
