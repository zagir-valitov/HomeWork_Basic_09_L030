﻿using System;
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

    public async Task Download(string fileName, string remoteUri)
    {
        var myWebClient = new WebClient();
        ImageStarted?.Invoke("File downloaded started!");
        Console.WriteLine($"Downloading a {fileName} from {remoteUri}");
        await myWebClient.DownloadFileTaskAsync( remoteUri, fileName );
        Console.WriteLine($"Successfully downloaded a {fileName} from {remoteUri}");
        ImageCompleted?.Invoke("File download completed!");
    }
}
