namespace CodeTest.Core.Validation
{
    public class IntValidation
    {
        public static bool IsIntGreaterThan0(int value)
        {
            if(value > 0)
            {
                return true;
            }
            
            return false;
        }
    }
}
