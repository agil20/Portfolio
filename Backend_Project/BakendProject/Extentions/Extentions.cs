﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace BakendProject.Extentions
{
    public static class  Extentions
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("images");
        }

        public static bool ValidSize(this IFormFile file, int size)
        {
            return file.Length / 2024 > size;
        }
        public static string SaveImage(this IFormFile file, IWebHostEnvironment _env, string folder)
        {


            string fileName = Guid.NewGuid().ToString() + file.FileName;


            string path = Path.Combine(_env.WebRootPath, "images", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {

                file.CopyTo(stream);
            }
            return fileName;
        }
    }
}
