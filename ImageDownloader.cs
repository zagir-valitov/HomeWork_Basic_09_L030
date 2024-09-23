using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_09_L030;

internal class ImageDownloader
{
    public delegate void DownloadHandler(string message);
    public event DownloadHandler? ImageStarted;
    public event DownloadHandler? ImageCompleted;
    public static int Count = 1;
    public string Uri;
    public string? FileName;

    public ImageDownloader(string uri) 
    {
        Uri = uri;
    }

    public async Task Download()
    {
        FileName = $"picture_{Count++}.jpg";
        var myWebClient = new WebClient();

        ImageStarted?.Invoke($"File {FileName} downloaded started!");

        await myWebClient.DownloadFileTaskAsync( Uri, FileName );

        ImageCompleted?.Invoke($"File {FileName} download completed!");
    }
}
