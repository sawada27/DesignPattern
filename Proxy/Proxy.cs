using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Proxy
{


    public class ProxyLoader : IImageLoader
    {
        private RealLoader _realImage;
        private string _filename;

        public ProxyLoader(string filename)
        {
            _filename = filename;
        }


        public void Load()
        {
            if (_realImage == null)
            {
                _realImage = new RealLoader(_filename);
            }
            _realImage.Load();
        }
    }
}
