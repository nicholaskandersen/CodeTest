using CodeTest.Core.Helpers;
using CodeTest.Core.Models;
using System.Text;

namespace CodeTest.Core.Services
{
    public class FileService
    {
        public string PrependCommasToFile(int numberOfCommas, FileModel fileModel)
        {
            try
            {
                string commaStringToBePrepended = StringHelper.CreateCommaString(numberOfCommas);
                
                using (var reader = File.Open(fileModel.FullPath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    StreamReader streamReader = new StreamReader(reader);
                    string ExistingText = streamReader.ReadToEnd();
                    var prependText = commaStringToBePrepended + Environment.NewLine + ExistingText;
                    reader.Seek(0, SeekOrigin.Begin);
                    byte[] prependTextByteArray = Encoding.ASCII.GetBytes(prependText);
                    reader.Write(prependTextByteArray);
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                return "Commas failed to write.";
            }
            
            return "Commas succesfully added.";
        }
    }
}
