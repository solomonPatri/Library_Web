using Library_Web.Object.Model;
using Library_Web.Data;
using Microsoft.EntityFrameworkCore;
using Library_Web.Object.Dtos;

namespace Library_Web.Object.Repository
{
    public class LibraryRepo: ILibraryRepo
    {


        private readonly AppDbContext _appdbcontext;

        public LibraryRepo(AppDbContext context)
        {

            this._appdbcontext = context;
        }
        public async Task<List<Library>> GetLibrariesAsync()
        {

            return await _appdbcontext.Libraries.ToListAsync();

        }

        public async Task<List<GetLibraryByName>> GetByName()
        {


            return await _appdbcontext.Libraries.Select(lib => new GetLibraryByName { Name = lib.Name }).ToListAsync();





        }

    }

}