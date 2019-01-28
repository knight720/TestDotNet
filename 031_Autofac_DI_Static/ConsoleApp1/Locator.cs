using System;

namespace ConsoleApp1
{
    internal class Locator
    {
        private static Client _client;

        public static void Register(Client client)
        {
            _client = client;
        }

        public static void GetInstance()
        {
            if (_client == null)
            {
                throw new NullReferenceException("Client is null");
            }
            Console.WriteLine(_client.ToString());
        }
    }
}