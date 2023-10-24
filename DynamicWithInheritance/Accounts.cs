namespace DynamicWithInheritance
{
    public static class Accounts
    {
        public class Account
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Type { get; set; }
        }

        public class AccountBasic : Account
        {
            public string SomethingFromBasic { get; set; }
        }

        public class AccountPrime : Account
        {
            public string SomethingFromPrime { get; set; }
        }
    }
}