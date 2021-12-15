using Module3HW4.Models;

namespace Module3HW4
{
    public class Program
    {
        private static Func<int, int, int>? _sumHandler;

        public static void TryCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static int GetResult()
        {
            _sumHandler += (d, d1) => d + d1;
            _sumHandler += (d, d1) => d + d1;

            var sum = 0;
            var result = _sumHandler.GetInvocationList();
            foreach (var item in result)
            {
                var x = item.DynamicInvoke(7, 243);
                sum += (int)x!;
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            var result = 0;
            TryCatch(() =>
            {
                result = GetResult();
            });
            Console.WriteLine(result);
            var users = new User[]
            {
                new User()
                {
                    FirstName = "asd",
                    LastName = "sad",
                    Age = 12,
                    PhoneNumber = "21343242342"
                },
                new User()
                {
                    FirstName = "gfd",
                    LastName = "ert",
                    Age = 54,
                    PhoneNumber = "7856786"
                },
                new User()
                {
                    FirstName = "ghj",
                    LastName = "yuoy",
                    Age = 67,
                    PhoneNumber = "46364364"
                },
                new User()
                {
                    FirstName = "oify",
                    LastName = "gfegc",
                    Age = 42,
                    PhoneNumber = "546547457452"
                },
                new User()
                {
                    FirstName = "fdsbds",
                    LastName = "shgerty",
                    Age = 54,
                    PhoneNumber = "68536456"
                },
                new User()
                {
                    FirstName = "fgdfsh",
                    LastName = "nfghkdy",
                    Age = 65,
                    PhoneNumber = "46536436463"
                },
                new User()
                {
                    FirstName = "vczvbz",
                    LastName = "dfhsdbvcxhdfhsdf",
                    Age = 78,
                    PhoneNumber = "23654634564"
                }
            }.ToList();

            var users2 = new User[]
            {
                new User()
                {
                    FirstName = "fgdfsh",
                    LastName = "shgerty",
                    Age = 13,
                    PhoneNumber = "754748765"
                },
                new User()
                {
                    FirstName = "ruteinb",
                    LastName = "nfghkdy",
                    Age = 14,
                    PhoneNumber = "65853"
                },
                new User()
                {
                    FirstName = "vczvbz",
                    LastName = "dfhsdbvcxhdfhsdf",
                    Age = 17,
                    PhoneNumber = "656435"
                }
            }.ToList();
            var firstOrDefault = users.FirstOrDefault(user => user.Age > 30);
            var where = users.Where(user => user.Age > 30);
            var select = users.Select(user => user.Age);
            var orderBy = users.OrderBy(user => user.FirstName);
            var thenBy = orderBy.ThenBy(user => user.Age);
            var join =
                users.Join(
                    users2,
                    user => user.LastName,
                    user2 => user2.LastName,
                    (user, user2) =>
                        new { User1Age = user.LastName, User2 = user2.LastName });
        }
    }
}