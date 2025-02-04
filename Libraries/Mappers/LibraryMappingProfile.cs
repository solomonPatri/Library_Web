using AutoMapper;
using Library_Web.Libraries.Dtos;
using Library_Web.Libraries.Model;
using Library_Web.Libraries.Repository;

namespace Library_Web.Libraries.Mappers
{
    public class LibraryMappingProfile:Profile
    {
        public LibraryMappingProfile()
        {

            CreateMap<LibraryRequest, Library>();
            CreateMap<Library, LibraryResponse>();
            CreateMap<LibraryResponse, LibraryUpdateRequest>();



        }








    }
}
