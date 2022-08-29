using BlazorInputFile;
using Dating_App.Services;

namespace Dating_App.Data
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _oWebHostEnvironment;
        public FileUpload(IWebHostEnvironment oWebHostEnvironmen)
        {
            _oWebHostEnvironment = oWebHostEnvironmen;
        }
        public async Task Upload(IFileListEntry file, SessionState state)
        {
            var path = Path.Combine(_oWebHostEnvironment.ContentRootPath, "userImages/" + state.Username, file.Name);
            var memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);

            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                memoryStream.WriteTo(fileStream);
            }
        }
    }
}
