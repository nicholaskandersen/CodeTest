namespace CodeTest.Core.Validation
{
    public class FileValidation
    {
        public static bool IsPathValid(string filePath)
        {
            if(filePath == null)
            {
                return false;
            }
                    
            if (!File.Exists(filePath))
            {
                return false;
            }

            return true;
        }
    }
}
