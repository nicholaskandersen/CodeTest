using CodeTest.Core.Helpers;
using CodeTest.Core.Models;
using CodeTest.Core.Services;

namespace CodeTest.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileService fileService = new FileService();
            UserInput userInput = new UserInput();

            var numberOfCommasToPrepend = userInput.GetNumberOfCommasToPrepend();
            var filePath = userInput.GetFilePath();

            FileModel fileModel = FileHelper.CreateFileModelFromFullPath(filePath);

            var result = fileService.PrependCommasToFile(numberOfCommasToPrepend, fileModel);

            Console.WriteLine(result);
        }
    }
}
