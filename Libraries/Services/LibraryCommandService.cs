using Library_Web.Libraries.Dtos;
using Library_Web.Libraries.Repository;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Library_Web.Libraries.Exceptions;
namespace Library_Web.Libraries.Services
{
    public class LibraryCommandService:ILibraryCommandService
    {

        private readonly ILibraryRepo _repo;

        public LibraryCommandService(ILibraryRepo repo)
        {
            this._repo = repo;


        }


        public async Task<LibraryResponse> CreateAsync(LibraryRequest createRequest)
        {

            LibraryResponse library = await _repo.FindByName(createRequest.Name);

            if (library == null)
            {
                LibraryResponse response = await _repo.CreateAsync(createRequest);

                return response;

            }

            throw new LibraryAlreadyExistExceptions();

        }

        public async Task<LibraryResponse> DeleteAsync(int id)
        {
            LibraryResponse library = await _repo.FindById(id);

            if(library != null)
            {
                LibraryResponse response = await _repo.DeleteAsync(id);

                return response;



            }

            throw new LibraryNotFoundException();



        }


        public async Task<LibraryResponse> UpdateAsync(int id,LibraryUpdateRequest update)
        {

            LibraryResponse library = await _repo.FindById(id);

            if (library != null)
            {
                if(library is LibraryUpdateRequest)
                {

                    library.Name = update.Name ?? library.Name;
                    library.Address = update.Address ?? library.Address;
                    library.Places = update.Places ?? library.Places;
                    library.Inauguration = update.Inauguration ?? library.Inauguration;
                    library.SoldBooks = update.SoldBooks ?? library.SoldBooks;

                    LibraryResponse response = await _repo.UpdateAsync(id, update);

                    return response;

                }

                throw new LibraryNotUpdateExceptions();


            }

            throw new LibraryNotFoundException();


        }






































    }
}
