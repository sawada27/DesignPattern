using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Proxy
{
    public interface IImageLoader
    {
        void Load();
    }

    public class RealLoader : IImageLoader
    {
        private string _filename;

        public RealLoader(string filename)
        {
            _filename = filename;
        
        }
        public void Load()
        {
            Console.WriteLine($"Load image {_filename}");
        }
    }

}
