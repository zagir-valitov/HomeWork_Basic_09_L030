using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_09_L030;

internal class ImageDownloader
{
    //public delegate void DownloadHandler(string message);
    //public event DownloadHandler? ImageStartedNotify;
    //public event DownloadHandler? ImageCompletedNotify;
    public event Action<string>? ImageStartedNotify;
    public event Action<string>? ImageCompletedNotify;
    public static int Count = 1;
    public static List<string> DownloadList = [];
    
    public async Task DownloadAsync(string uri, string fileName)
    {
        fileName = $"{fileName}_{Count++}.jpg";
        DownloadList.Add(fileName);
        ImageStartedNotify?.Invoke($"File {fileName} downloaded started!");
        using (var myWebClient = new WebClient())
        {
            await myWebClient.DownloadFileTaskAsync(uri, fileName);
        }
        ImageCompletedNotify?.Invoke($"File {fileName} download completed!");
    }
}
