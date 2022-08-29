using BlazorInputFile;
using Dating_App.Data;

namespace Dating_App.Services
{
    public interface IFileUpload
    {
        Task Upload(IFileListEntry file, SessionState state);
    }
}
