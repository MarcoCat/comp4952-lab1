namespace ZodiacApp.Models
{
    public static class Utils
    {
        public static string GetZodiac(int year)
        {
            string[] zodiac =
            [
                "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox",
                "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat"
            ];

            int remainder = year % 12;
            return zodiac[remainder];
        }
    }
}
