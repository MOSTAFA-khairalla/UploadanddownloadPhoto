using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace UploadanddownloadPhoto.Services
{
    public interface IFileService
    {

            void UploadFile(List<IFormFile> files, string subDirectory);
            (string fileType, byte[] archiveData, string archiveName) DownloadFiles(string subDirectory);
            string SizeConverter(long bytes);
      
    }
}
