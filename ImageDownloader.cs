using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_09_L030
{
    internal class ImageDownloader
    {
        public void Download(string fileName, string remoteUri)
        {
            var myWebClient = new WebClient();
            Console.WriteLine($"Downloading a {fileName} from {remoteUri}");
            myWebClient.DownloadFile( remoteUri, fileName );
            Console.WriteLine($"Successfully downloaded a {fileName} from {remoteUri}");
        }
    }
}
