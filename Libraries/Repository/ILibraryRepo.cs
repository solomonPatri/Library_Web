using Library_Web.Data;
using Library_Web.Libraries.Model;
using Library_Web.Libraries.Dtos;

namespace Library_Web.Libraries.Repository
{
    public interface ILibraryRepo
    {

        Task<List<Library>> GetAllAsync();

        Task<CreateLibraryResponse> CreateLibrary(CreateLibraryRequest createResquet);
       


        



    }
}
