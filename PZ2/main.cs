using System;
using System.Text.RegularExpressions;

record IP4(byte[] Address);

class Parser
{
    private Regex regex = new Regex(@"^(?!\.)[\w-_.]*@[\w-_.]+\.[a-zA-Z]+$");

    public IP4 Parse(string s)
    {
        Match match = regex.Match(s);
        if (!match.Success)
        {
            return null;
        }
        return new IP4(new byte[] { 192, 168, 0, 1 });
    }
}

class Program
{
    static void Main(string[] args)
    {
        string s;
        Parser parser = new Parser();
        while ((s = Console.ReadLine()) != null)
        {
            IP4 ip = parser.Parse(s);
            if (ip == null)
            {
                Console.WriteLine($"Invalid email: {s}");
            }
            else
            {
                Console.WriteLine($"Parsed email: {ip}");
            }
        }
    }
}
