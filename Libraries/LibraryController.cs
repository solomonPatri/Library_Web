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

        public async Task<ActionResult<CreateLibraryResponse>>   CreateLibrary(CreateLibraryRequest createRequest)
        {

            CreateLibraryResponse create = await _libraryRepo.CreateLibrary(createRequest);

            return Created("", create);




        }









    }
}
