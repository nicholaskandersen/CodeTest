using CodeTest.Core.Models;

namespace CodeTest.Core.Helpers
{
    public class FileHelper
    {
        public static FileModel CreateFileModelFromFullPath(string fullPath)
        {
            FileModel fileModel = new FileModel();

            fileModel.Name = fullPath.Substring(fullPath.LastIndexOf("\\" )+ 1);
            fileModel.DirectoryPath = fullPath.Substring(0, fullPath.LastIndexOf("\\") + 1);
            fileModel.FullPath = fullPath;
            return fileModel;
        }
    }
}
