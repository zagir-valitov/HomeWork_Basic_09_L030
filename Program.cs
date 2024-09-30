using HomeWork_Basic_09_L030;
using System.Text;

Console.WriteLine(" ---- Home work 9 ----\n");

var status = "Download status:\n";
var statusString = new StringBuilder(status);

var imageDownloader = new ImageDownloader();
imageDownloader.ImageStartedNotify += DisplayStartedMessage;
imageDownloader.ImageCompletedNotify += DisplayCompletedMessage;

CancellationTokenSource cts = new CancellationTokenSource();
CancellationToken token = cts.Token;

Task task = new Task(() =>
{
    var fileName = "picture";

    var task1 = imageDownloader.DownloadAsync(
        "https://img2.akspic.ru/crops/8/6/4/5/7/175468/" +
        "175468-seealpsee-gora-oblako-rastenie-zelenyj-" +
        "7680x4320.jpg", fileName);
    var task2 = imageDownloader.DownloadAsync(
        "https://img2.akspic.ru/crops/1/5/9/7/7/177951/" +
        "177951-shotlandiya_pejzazh-shotlandskoe_nagore-zapovednik_alladejl-gora-oblako-" +
        "3840x2160.jpg", fileName);
    var task3 = imageDownloader.DownloadAsync(
        "https://img3.akspic.ru/crops/7/2/9/7/7/177927/" +
        "177927-gora_everest-gora-sammit-gornyj_hrebet-planshet-" +
        "3840x2160.jpg", fileName);
    var task4 = imageDownloader.DownloadAsync(
        "https://img1.akspic.ru/crops/8/1/3/8/7/178318/" +
        "178318-nacionalnyj_park_grand_titon-grand_titon-delta_ozero-reki_snejk-nacionalnyj_park_grand_titon_vajoming-" +
        "3840x2160.jpg", fileName);
    var task5 = imageDownloader.DownloadAsync(
        "https://img1.akspic.ru/crops/4/2/3/7/7/177324/" +
        "177324-64_bitnye_vychisleniya-windows_10-voda-lazurnyj-rastenie-" +
        "3840x2160.jpg", fileName);
    var task6 = imageDownloader.DownloadAsync(
        "https://img2.akspic.ru/crops/3/5/9/7/7/177953/" +
        "177953-derevo_dzhoshua_nacionalnyj_park-zapovednik_s_vidom_na_pustynyu-plotina_barkera-makaron-mohave-" +
        "1920x1080.jpg", fileName);
    var task7 = imageDownloader.DownloadAsync(
        "https://img2.akspic.ru/crops/3/5/9/7/7/177953/" +
        "177953-derevo_dzhoshua_nacionalnyj_park-zapovednik_s_vidom_na_pustynyu-plotina_barkera-makaron-mohave-" +
        "1920x1080.jpg", fileName);
    var task8 = imageDownloader.DownloadAsync(
        "https://img1.akspic.ru/crops/5/8/7/8/7/178785/" +
        "178785-polet-samolet-samolety-aviaciya-reaktivnyj_samolet-" +
        "1920x1080.jpg", fileName);
    var task9 = imageDownloader.DownloadAsync(
        "https://img3.akspic.ru/crops/2/6/8/8/7/178862/" +
        "178862-zerkalo_ozera-stena-semnyj_nositel-ozero-freska-" +
        "3840x2160.jpg", fileName);
    var task10 = imageDownloader.DownloadAsync(
        "https://img1.akspic.ru/crops/3/6/2/6/7/176263/" +
        "176263-otrazhenie-zhitel_zapada-lofoten-oblako-voda-" +
        "1920x1080.jpg", fileName);

    while (true)
    {
        Console.WriteLine("\nPress \"A\" to exit or any other key to check the download status\n");

        var command = Console.ReadLine();
        if (command == "A")
        {
            cts.Cancel();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Operation interrupted");
            Console.WriteLine("\n ------ !Exit! ------");
            Console.ResetColor();
            return;
        }

        var taskList = new List<Task>() { task1, task2, task3, task4, task5, task6, task7, task8, task9, task10 };

        if (Task.WhenAll(taskList).IsCompleted)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All files downloaded!!!");
            Console.ResetColor();
        }
        else
        {
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine($"File {ImageDownloader.DownloadList[i]} - Download is completed: {taskList[i].IsCompleted}");
            }
        }
    }
},token);
task.Start();
task.Wait();

Console.WriteLine($"Task status: {task.Status}");
cts.Dispose();

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