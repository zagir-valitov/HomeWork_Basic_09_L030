using HomeWork_Basic_09_L030;
using System.Text;

Console.WriteLine(" ---- Home work 9 ----\n");

var status = "Download status:\n";
var statusString = new StringBuilder(status);

var imageDownloader1 = new ImageDownloader(
    "https://img2.akspic.ru/crops/8/6/4/5/7/175468/" +
    "175468-seealpsee-gora-oblako-rastenie-zelenyj-" +
    "7680x4320.jpg");
var imageDownloader2 = new ImageDownloader(
    "https://img1.akspic.ru/crops/4/4/7/8/7/178744/" +
    "178744-kordilera_uajuash-ozero_karuakocha-gornyj_hrebet-gora-atmosfera-" +
    "3840x2160.jpg");
var imageDownloader3 = new ImageDownloader(
    "https://img2.akspic.ru/crops/1/5/9/7/7/177951/" +
    "177951-shotlandiya_pejzazh-shotlandskoe_nagore-zapovednik_alladejl-gora-oblako-" +
    "3840x2160.jpg");
var imageDownloader4 = new ImageDownloader(
    "https://img3.akspic.ru/crops/7/2/9/7/7/177927/" +
    "177927-gora_everest-gora-sammit-gornyj_hrebet-planshet-" +
    "3840x2160.jpg");
var imageDownloader5 = new ImageDownloader(
    "https://img1.akspic.ru/crops/8/1/3/8/7/178318/" +
    "178318-nacionalnyj_park_grand_titon-grand_titon-delta_ozero-reki_snejk-nacionalnyj_park_grand_titon_vajoming-" +
    "3840x2160.jpg");
var imageDownloader6 = new ImageDownloader(
    "https://img1.akspic.ru/crops/4/2/3/7/7/177324/" +
    "177324-64_bitnye_vychisleniya-windows_10-voda-lazurnyj-rastenie-" +
    "3840x2160.jpg");
var imageDownloader7 = new ImageDownloader(
    "https://img2.akspic.ru/crops/3/5/9/7/7/177953/" +
    "177953-derevo_dzhoshua_nacionalnyj_park-zapovednik_s_vidom_na_pustynyu-plotina_barkera-makaron-mohave-" +
    "1920x1080.jpg");
var imageDownloader8 = new ImageDownloader(
    "https://img1.akspic.ru/crops/5/8/7/8/7/178785/" +
    "178785-polet-samolet-samolety-aviaciya-reaktivnyj_samolet-" +
    "1920x1080.jpg");
var imageDownloader9 = new ImageDownloader(
    "https://img3.akspic.ru/crops/2/6/8/8/7/178862/" +
    "178862-zerkalo_ozera-stena-semnyj_nositel-ozero-freska-" +
    "3840x2160.jpg");
var imageDownloader10 = new ImageDownloader(
    "https://img1.akspic.ru/crops/3/6/2/6/7/176263/" +
    "176263-otrazhenie-zhitel_zapada-lofoten-oblako-voda-" +
    "1920x1080.jpg");

imageDownloader1.ImageStartedNotify += DisplayStartedMessage;
imageDownloader2.ImageStartedNotify += DisplayStartedMessage;
imageDownloader3.ImageStartedNotify += DisplayStartedMessage;
imageDownloader4.ImageStartedNotify += DisplayStartedMessage;
imageDownloader5.ImageStartedNotify += DisplayStartedMessage;
imageDownloader6.ImageStartedNotify += DisplayStartedMessage;
imageDownloader7.ImageStartedNotify += DisplayStartedMessage;
imageDownloader8.ImageStartedNotify += DisplayStartedMessage;
imageDownloader9.ImageStartedNotify += DisplayStartedMessage;
imageDownloader10.ImageStartedNotify += DisplayStartedMessage;

imageDownloader1.ImageCompletedNotify += DisplayCompletedMessage;
imageDownloader2.ImageCompletedNotify += DisplayCompletedMessage;
imageDownloader3.ImageCompletedNotify += DisplayCompletedMessage;
imageDownloader4.ImageCompletedNotify += DisplayCompletedMessage;
imageDownloader5.ImageCompletedNotify += DisplayCompletedMessage;
imageDownloader6.ImageCompletedNotify += DisplayCompletedMessage;
imageDownloader7.ImageCompletedNotify += DisplayCompletedMessage;
imageDownloader8.ImageCompletedNotify += DisplayCompletedMessage;
imageDownloader9.ImageCompletedNotify += DisplayCompletedMessage;
imageDownloader10.ImageCompletedNotify += DisplayCompletedMessage;

var task1 = imageDownloader1.DownloadAsync();
var task2 = imageDownloader2.DownloadAsync();
var task3 = imageDownloader3.DownloadAsync();
var task4 = imageDownloader4.DownloadAsync();
var task5 = imageDownloader5.DownloadAsync();
var task6 = imageDownloader6.DownloadAsync();
var task7 = imageDownloader7.DownloadAsync();
var task8 = imageDownloader8.DownloadAsync();
var task9 = imageDownloader9.DownloadAsync();
var task10 = imageDownloader10.DownloadAsync();

while(true)
{
    Console.WriteLine("\nPress \"A\" to exit or any other key to check the download status\n");

    var command = Console.ReadLine();
    if(command == "A")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n --- Exit! ---");
        Console.ResetColor();
        break; 
    }

    if (task1.IsCompleted && task2.IsCompleted && task3.IsCompleted && task4.IsCompleted && task5.IsCompleted &&
        task6.IsCompleted && task7.IsCompleted && task8.IsCompleted && task9.IsCompleted && task10.IsCompleted)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("All files downloaded!!!");
        Console.ResetColor();
    }
    else
    {
        statusString.Append($"File: {imageDownloader1.FileName} - Download is completed: {task1.IsCompleted}\n");
        statusString.Append($"File: {imageDownloader2.FileName} - Download is completed: {task2.IsCompleted}\n");
        statusString.Append($"File: {imageDownloader3.FileName} - Download is completed: {task3.IsCompleted}\n");
        statusString.Append($"File: {imageDownloader4.FileName} - Download is completed: {task4.IsCompleted}\n");
        statusString.Append($"File: {imageDownloader5.FileName} - Download is completed: {task5.IsCompleted}\n");
        statusString.Append($"File: {imageDownloader6.FileName} - Download is completed: {task6.IsCompleted}\n");
        statusString.Append($"File: {imageDownloader7.FileName} - Download is completed: {task7.IsCompleted}\n");
        statusString.Append($"File: {imageDownloader8.FileName} - Download is completed: {task8.IsCompleted}\n");
        statusString.Append($"File: {imageDownloader9.FileName} - Download is completed: {task9.IsCompleted}\n");
        statusString.Append($"File: {imageDownloader10.FileName} - Download is completed: {task10.IsCompleted}\n");

        Console.WriteLine(statusString);
        statusString.Remove(status.Length, statusString.Length - status.Length);
    }
}

void DisplayStartedMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{message}");
    Console.ResetColor();
}
void DisplayCompletedMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{message}");
    Console.ResetColor();
}