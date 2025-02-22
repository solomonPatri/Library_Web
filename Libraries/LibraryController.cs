using Library_Web.Libraries.Dtos;
using Library_Web.Libraries.Exceptions;
using Library_Web.Libraries.Model;
using Library_Web.Libraries.Repository;
using Library_Web.Libraries.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.ComTypes;

namespace Library_Web.Libraries
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class LibraryController : ControllerBase
    {

        private ILibraryQueryService _queryService;
        private ILibraryCommandService _commandservice;


        public LibraryController(ILibraryQueryService query,ILibraryCommandService command)
        {

            this._queryService = query;
            this._commandservice = command;

        }


        [HttpGet("all")]

        public async Task<ActionResult<IEnumerable<Library>>> GetAllAsync()
        {

            var lib = await _queryService.GetAllLibrariesAsync();

            return Ok(lib);

        }

        [HttpPost("create")]

        public async Task<ActionResult<LibraryResponse>> CreateAsync([FromBody] LibraryRequest createRequest)
        {
            try
            {
                LibraryResponse response = await _commandservice.CreateAsync(createRequest);

                return Created("",response);


            }catch(LibraryAlreadyExistExceptions ex)
            {
                return BadRequest(ex.Message);
            }


     


        }

        [HttpDelete("delete/{id}")]

        public async Task<ActionResult<LibraryResponse>> DeleteAsync([FromRoute] int id)
        {
            try
            {
                LibraryResponse response = await _commandservice.DeleteAsync(id);
                return Accepted("", response);

            }catch(LibraryNotFoundException nf)
            {
                return NotFound(nf.Message);
            }
        }


        [HttpPut("edit/{id}")]


        public async Task<ActionResult<LibraryResponse>> UpdateAsync([FromRoute] int id, [FromBody] LibraryUpdateRequest update)
        {


            try
            {

                LibraryResponse response = await _commandservice.UpdateAsync(id, update);

                return Accepted(" ", response);

            }catch(LibraryNotFoundException nf)
            {
                return NotFound(nf.Message);

            }



        }


        [HttpGet("find/Name/{name}")]


        public async Task<ActionResult<LibraryResponse>> FindByName([FromRoute] string name)
        {

            try
            {
                LibraryResponse response = await _queryService.FindByName(name);
                return Accepted("", response);


            } catch (LibraryNotFoundException ex)
            {
                return NotFound(ex.Message);

            }
        }

        [HttpGet("find/id/{id}")]

        public async Task<ActionResult<LibraryResponse>> GetById([FromRoute]int id)
        {

            try
            {
                LibraryResponse response = await _queryService.FindById(id);

                return Accepted("", response);



            }catch(LibraryNotFoundException nf)
            {
                return NotFound(nf.Message);
            }



        }

        [HttpGet("GetAllNames")]

        public async Task<ActionResult<LibraryNameList>> GetAllNames()
        {
            try
            {
                LibraryNameList response = await _queryService.GetAllNames();

                return Accepted("", response);

            }catch(LibraryNotFoundException nf)
            {
                return NotFound(nf.Message);
            }





        }
            



















    }
}
