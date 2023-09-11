internal class Program
{
    static void Main()
    {
        int totalScore = 0;

        while (true)
        {
            Console.WriteLine("Oyun başlıyor...");
            char randomLetter = RandomLetter();
            Console.WriteLine($"Rastgele harf: {randomLetter}");

            List<string> titles = new List<string>
            {
                "İsim",
                "Şehir",
                "Hayvan",
                "Bitki",
                "Eşya",
                "Ülke",
                "Ünlü İsim"
            };

            foreach (string title in titles)
            {
                Console.Write($"Lütfen bir {title} girin : \n");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Boş bırakılamaz.");
                    continue;
                }

                if (input.ToLower()[0] == randomLetter)
                {
                    //Console.WriteLine("Doğru!");
                    totalScore+=10;
                }
                else
                {
                    Console.WriteLine("Yanlış!");
                }
            }

            Console.WriteLine($"Oyun sona erdi. \nToplam Puan: {totalScore}\n");
            Console.Write("Başka bir oyun oynamak ister misiniz? \n (Evet: e / Hayır: herhangi bir tuş): ");
            string playAgain = Console.ReadLine();

            if (playAgain.ToLower() != "e")
            {
                break;
            }
        }
    }

    static char RandomLetter()
    {
        Random random = new Random();
        char randomLetter = (char)('a' + random.Next(26));
        return randomLetter;
    }

}
