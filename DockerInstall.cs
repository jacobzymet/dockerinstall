using System;

namespace DockerInstall
{
    class Entry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Docker installation program.");
            Console.WriteLine("We detected you are running " + new OSdetect().OS());
        }
    }
    class OSdetect
    {
        public string OS()
        {
            string os = Environment.OSVersion.ToString();
            return os;
        }
    }
}