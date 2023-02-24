using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoImplantacaoMovimento.Services
{
    public class FileService
    {
        private string _path;
        public FileService(string path)
        {
            _path = path;
        }

        public void WriteFile(string data)
        {
            string readFile = File.ReadAllText(_path);
            readFile += data + Environment.NewLine;
            File.WriteAllText(_path, readFile);
        }
    }
}
