using Library_Web.Libraries.Dtos;
using Library_Web.Libraries.Model;

namespace Library_Web.Libraries.Services
{
    public interface ILibraryQueryService
    {

        Task<List<Library>> GetAllLibrariesAsync();

        Task<LibraryResponse> FindById(int id);

        Task<LibraryResponse> FindByName(string name);


        Task<LibraryNameList> GetAllNames();




    }
}
