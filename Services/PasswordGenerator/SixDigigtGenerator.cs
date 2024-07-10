namespace HW_ASP_2.Services.PasswordGenerator
{
    public class SixDigitGenerator : IPasswordGenerator
    {
        public string Generate()
        {
            Random r = new Random();
            int[] ints = new int[6];
            for (int i = 0; i <= ints.Length - 1; i++)
            {
                ints[i] = r.Next(9);
            }
            string res = $"{ints[0]}{ints[1]}{ints[2]}{ints[3]}{ints[4]}{ints[5]}";
            return res ;
        }
    }
}
