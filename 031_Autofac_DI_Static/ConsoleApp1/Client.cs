using System;

namespace ConsoleApp1
{
    public class Client
    {
        public string id;

        public Client()
        {
            this.id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return id;
        }
    }
}