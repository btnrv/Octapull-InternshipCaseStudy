using System.Runtime.CompilerServices;

namespace OctaMeet.FileUpload
{
    public interface Interface
    {
        Task<string> UploadFileAsync(IFormFile file);
    }
}
