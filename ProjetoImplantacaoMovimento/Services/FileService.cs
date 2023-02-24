using System;
using System.IO;

namespace ProjetoImplantacaoMovimento.Services
{
    public class FileService
    {
        public void WriteFile(string data, string path)
        {
            string readFile = File.ReadAllText(path);
            readFile += data + Environment.NewLine;
            File.WriteAllText(path, readFile);
        }

        public string[] ReadFile(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
