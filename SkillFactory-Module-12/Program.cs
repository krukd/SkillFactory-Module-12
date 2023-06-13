namespace SkillFactory_Module_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User() {Login="login1", Name = "Vasya", IsPremium = false},
                new User() {Login="login2", Name = "Petya", IsPremium = true},
                new User() {Login="login3", Name = "Kolya", IsPremium = false},
            };

            foreach (var user in users)
            {
                GreetUser(user);
            }

            Console.ReadKey();
        }

        static void GreetUser(User user)
        {
            Console.WriteLine($"Hello, {user.Name}!");
            Thread.Sleep(2000);
            if (!user.IsPremium)
            {
                ShowAds();
            }

        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}