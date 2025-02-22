using Library_Web.Libraries.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Library_Web.Libraries.Services
{
    public interface ILibraryCommandService
    {


        Task<LibraryResponse> CreateAsync(LibraryRequest createRequest);


        Task<LibraryResponse> UpdateAsync(int id, LibraryUpdateRequest update);

        Task<LibraryResponse> DeleteAsync(int id);






    }


}
