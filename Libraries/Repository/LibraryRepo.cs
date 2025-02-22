using Library_Web.Libraries.Model;
using Library_Web.Data;
using Microsoft.EntityFrameworkCore;
using Library_Web.Libraries.Dtos;
using AutoMapper;

namespace Library_Web.Libraries.Repository
{
    public class LibraryRepo:ILibraryRepo
    {


        private readonly AppDbContext _appdbcontext;
        private readonly IMapper _mapper;

        public LibraryRepo(AppDbContext context,IMapper mapper)
        {

            this._appdbcontext = context;
            this._mapper = mapper;
        }

        public async Task<List<Library>> GetAllAsync()
        {

            return await _appdbcontext.Libraries.ToListAsync();



        }


       public async Task<LibraryResponse> CreateAsync(LibraryRequest createResquet)
        {
            Library libr = _mapper.Map<Library>(createResquet);

            _appdbcontext.Libraries.Add(libr);

            await _appdbcontext.SaveChangesAsync();

            LibraryResponse response = _mapper.Map<LibraryResponse>(libr);

            return response;

        }

        public async Task<LibraryResponse> DeleteAsync(int id)
        {

            Library lib = await _appdbcontext.Libraries.FindAsync(id);

            LibraryResponse response = _mapper.Map<LibraryResponse>(lib);


            _appdbcontext.SaveChangesAsync();

            return response;
        }


        public async Task<LibraryResponse> UpdateAsync(int id, LibraryUpdateRequest update)
        {

            Library lib = await _appdbcontext.Libraries.FindAsync(id);

            if (update.Name != null)
            {

                lib.Name = update.Name;

            }

            if (update.Address != null)
            {

                lib.Address = update.Address;

            }

            if (update.Places.HasValue)
            {

                lib.Places = update.Places.Value;
            }

            if (update.Inauguration.HasValue)
            {

                lib.Inauguration = update.Inauguration.Value;

            }


            if (update.SoldBooks.HasValue)
            {
                lib.SoldBooks = update.SoldBooks.Value;
            }


            _appdbcontext.Libraries.Update(lib);


            await _appdbcontext.SaveChangesAsync();

            LibraryResponse response = _mapper.Map<LibraryResponse>(lib);

            return response;

        }

       
        public async Task<LibraryNameList> GetAllNames()
        {
            List<string> names = await _appdbcontext.Libraries.Select(n => n.Name).ToListAsync();

            LibraryNameList response = new LibraryNameList();

            response.Names = names;

            return response;


        }


        public async Task<LibraryResponse> FindByName(string name)
        {

            Library found = await _appdbcontext.Libraries.FirstOrDefaultAsync(n => n.Name.Equals(name));

            LibraryResponse response = _mapper.Map<LibraryResponse>(found);

            return response;



        }


        public async Task<LibraryResponse> FindById(int id)
        {

            Library found = await _appdbcontext.Libraries.FindAsync(id);

            LibraryResponse response = _mapper.Map<LibraryResponse>(found);

            return response;


        }






    }

}