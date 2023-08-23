using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class MP3Player
    {
        public void PlayMP3(string fileName)
        {
            Console.WriteLine($"Playing MP3 file: {fileName}");
        }
    }
}
