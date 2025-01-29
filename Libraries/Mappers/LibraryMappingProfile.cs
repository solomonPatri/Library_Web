using AutoMapper;
using Library_Web.Libraries.Dtos;
using Library_Web.Libraries.Model;

namespace Library_Web.Libraries.Mappers
{
    public class LibraryMappingProfile:Profile
    {
        public LibraryMappingProfile()
        {

            CreateMap<CreateLibraryRequest, Library>();
            CreateMap<Library, CreateLibraryResponse>();
        }








    }
}
