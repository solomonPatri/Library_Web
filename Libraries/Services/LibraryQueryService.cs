using Library_Web.Libraries.Dtos;
using Library_Web.Libraries.Model;
using Library_Web.Libraries.Repository;
using Library_Web.Libraries.Exceptions;

namespace Library_Web.Libraries.Services
{
    public class LibraryQueryService :ILibraryQueryService
    {
        private ILibraryRepo _repo;

        public LibraryQueryService(ILibraryRepo repo)
        {

            this._repo = repo;
        }


        public async Task<List<Library>> GetAllLibrariesAsync()
        {
            return await _repo.GetAllAsync();


        }

        public async Task<LibraryResponse> FindByName(string name)
        {

            LibraryResponse response = await _repo.FindByName(name);

            if(response != null)
            {

                return response;

            }
            throw new LibraryNotFoundException();



        }

        public async Task<LibraryResponse> FindById(int id)
        {

            LibraryResponse response = await _repo.FindById(id);

            if(response != null)
            {
                return response;
            }
            throw new LibraryNotFoundException();

        }

        public async Task<LibraryNameList> GetAllNames()
        {

            LibraryNameList response = await _repo.GetAllNames();
            if(response != null)
            {

                return response;
            }

            throw new LibraryNotFoundException();


        }












    }
}
