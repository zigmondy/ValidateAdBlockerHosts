using System.IO;

namespace ValidateAdBlockerHosts
{
    using System.Net;

    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter("out.txt"))
            {
                using (var reader = new StreamReader("in.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith("0.0.0.0"))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}
