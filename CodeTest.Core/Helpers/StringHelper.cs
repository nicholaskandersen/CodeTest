namespace CodeTest.Core.Helpers
{
    public class StringHelper
    {
        public static string CreateCommaString(int numberOfCommas)
        {
            string commaString = "";
            for (int i = 0; i < numberOfCommas; i++)
            {
                commaString = commaString + ",";
            }

            return commaString;
        }

        public static int ConvertNumericStringToInt(string numericString)
        {
            int convertedValue = 0;
            if (int.TryParse(numericString, out convertedValue))
            {
                return convertedValue;
            }

            return 0;
        }
    }
}
