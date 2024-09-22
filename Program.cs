using HomeWork_Basic_09_L030;

Console.WriteLine(" ---- Home work 9 ----\n");

var imageDownloader = new ImageDownloader();
imageDownloader.ImageStarted += DisplayStartedMessage;
imageDownloader.ImageCompleted += DisplayCompletedMessage;

Task task1 = Task.Run(() =>
{
    imageDownloader?.Download("BigPic_1.jpg", "https://img2.akspic.ru/crops/8/6/4/5/7/175468/" +
        "175468-seealpsee-gora-oblako-rastenie-zelenyj-7680x4320.jpg");
});
Console.WriteLine("Press \"A\" to exit or any other key to check the download status");
while(true)
{
    var command = Console.ReadLine();
    if(command == "A")
    {
        Console.WriteLine("Exit!");
        break; 
    }
    Console.WriteLine($"Download is completed: {task1.IsCompleted}");
}

void DisplayStartedMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\n{message}\n");
    Console.ResetColor();
}
void DisplayCompletedMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\n{message}\n");
    Console.ResetColor();
}