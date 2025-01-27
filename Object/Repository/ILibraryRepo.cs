using Library_Web.Data;
using Library_Web.Object;
using Library_Web.Object.Model;
using Library_Web.Object.Dtos;

namespace Library_Web.Object.Repository
{
    public interface ILibraryRepo
    {


         Task<List<Library>> GetLibrariesAsync();

         Task<List<Library>> GetByName();


        



    }
}
