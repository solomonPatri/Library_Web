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


       public async Task<CreateLibraryResponse> CreateLibrary(CreateLibraryRequest createResquet)
        {
            Library libr = _mapper.Map<Library>(createResquet);

            _appdbcontext.Libraries.Add(libr);

            await _appdbcontext.SaveChangesAsync();

            CreateLibraryResponse response = _mapper.Map<CreateLibraryResponse>(libr);

            return response;





        }











    }

}