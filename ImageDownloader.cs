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
    public string Uri;
    public string? FileName;

    public ImageDownloader(string uri) 
    {
        Uri = uri;
    }

    public async Task DownloadAsync()
    {
        FileName = $"picture_{Count++}.jpg";
        ImageStartedNotify?.Invoke($"File {FileName} downloaded started!");
        using (var myWebClient = new WebClient())
        {
            await myWebClient.DownloadFileTaskAsync(Uri, FileName);
        }
        ImageCompletedNotify?.Invoke($"File {FileName} download completed!");
    }
}
