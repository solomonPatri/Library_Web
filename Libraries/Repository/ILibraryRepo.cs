using Library_Web.Data;
using Library_Web.Libraries.Model;
using Library_Web.Libraries.Dtos;

namespace Library_Web.Libraries.Repository
{
    public interface ILibraryRepo
    {

        Task<List<Library>> GetAllAsync();

        Task<LibraryResponse> CreateAsync(LibraryRequest createResquet);

        Task<LibraryResponse> DeleteAsync(int id);
        Task<LibraryResponse> UpdateAsync(int id, LibraryUpdateRequest lib);

        Task<LibraryNameList> GetAllNames();

        Task<LibraryResponse> FindByName(string name);

        Task<LibraryResponse> FindById(int id);
        



    }
}
