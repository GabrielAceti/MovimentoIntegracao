using System;
using System.Collections.Generic;
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

        public void WriteAllLines(List<string> data, string path)
        {
            File.WriteAllLines(path, data);
        }

        public void ExcluiConteudo(string path)
        {
            File.Delete(path);
        }

        public string[] ReadFile(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
