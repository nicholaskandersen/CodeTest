using CodeTest.Core.Helpers;
using CodeTest.Core.Interfaces;
using CodeTest.Core.Validation;

namespace CodeTest.ConsoleApp
{
    public class UserInput : IUserInput
    {
        public int GetNumberOfCommasToPrepend()
        {
            Console.WriteLine("How many commas would you like to prepend?");
            int numberOfCommasToPrepend = StringHelper.ConvertNumericStringToInt(Console.ReadLine());

            while (!IntValidation.IsIntGreaterThan0(numberOfCommasToPrepend))
            {
                Console.WriteLine("Invalid entry, value must be an integer");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("How many commas would you like to prepend?");
                numberOfCommasToPrepend = StringHelper.ConvertNumericStringToInt(Console.ReadLine());
            }
            return numberOfCommasToPrepend;
        }

        public string GetFilePath()
        {
            Console.WriteLine("Enter the path of the file.");
            var filePath = Console.ReadLine();

            while (!FileValidation.IsPathValid(filePath))
            {
                Console.WriteLine("File path is invalid.");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Enter the path of the file.");
                filePath = Console.ReadLine();
            }
            
            return filePath;
        }
    }
}
