using Microsoft.EntityFrameworkCore.Update.Internal;

namespace Teamsd.Helpers
{
    public static class FileMnager
    {
        public static string SaveImage(string path, string FolderNmae, IFormFile file)
        {
            string name = file.FileName;
            name = name.Length > 100 ? name.Substring(name.Length - 100, 100) : name;

            //if(name.Length> 100) 
            //{
            //    name = name.Substring(name.Length - 100, 100);
            //}

            name = Guid.NewGuid().ToString() + name;

            string paths = Path.Combine(path,FolderNmae, name);
            using(FileStream fs = new FileStream(paths, FileMode.Create))
            {
                file.CopyTo(fs);
            }
            return name;
        }

        public static void DeleteImage(string pathd, string FolderNmaeD, string fileD)
        {
            string pathsD = Path.Combine(pathd,FolderNmaeD, fileD);
            if(File.Exists(pathsD))
            {
                File.Delete(pathsD);
            }
        }



    }
}
