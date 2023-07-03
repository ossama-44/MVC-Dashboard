using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace MVC.PL.Helper
{
    public class DocumentSettings
    {
        public static string UploadFile(IFormFile file, string folderName)
        {
            //var folderPath = @"D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 04\MVC.PL\MVC.PL\wwwroot\Files\Imgs\";
            //var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files/Imgs");
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files", folderName);

            var fileName = $"{Guid.NewGuid()}{Path.GetFileName(file.FileName)}";

            var filePath = Path.Combine(folderPath, fileName);

            using var fileStream = new FileStream(filePath, FileMode.Create);

            file.CopyTo(fileStream);

            return fileName;

        }
        public static void DeleteFile(string folderName, string fileName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files", folderName, fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
