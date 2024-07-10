namespace HW_ASP_2.Services.PasswordGenerator
{
    public class FourDigitGenerator : IPasswordGenerator
    {
        public string Generate()
        {
            Random r = new Random();
            int[] ints = new int[4];
            for (int i = 0; i <= ints.Length - 1; i++) //Если вам интересно почему здесь <= и -1, а не просто < - авторский почерк. Привычка то-ли с плюсов, то-ли с пайтона осталась.
            {
                ints[i] = r.Next(9);
            }
            string res = $"{ints[0]}{ints[1]}{ints[2]}{ints[3]}";
            return res;
        }
    }
}
