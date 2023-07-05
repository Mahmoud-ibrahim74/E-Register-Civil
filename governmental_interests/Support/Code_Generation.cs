using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Reflection;

namespace governmental_interests.Support
{
    class Code_Generation
    {
        private Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public void WriteCode()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string FilePath = Path.Combine(executableLocation, "CodeGenerations.txt");
            if(File.Exists(FilePath))
            {
                File.WriteAllText(FilePath, RandomString(20) + "\n");
            }
        }
        public string ReadCode()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string FilePath = Path.Combine(executableLocation, "CodeGenerations.txt");
            string getCode ="";
            if (File.Exists(FilePath))
            {
                getCode = File.ReadAllText(FilePath);
            }
            return getCode;
        }
    }
}
