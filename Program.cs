using HomeWork_Basic_09_L030;

Console.WriteLine(" ---- Home work 9 ----\n");

var imageDownloader = new ImageDownloader();
imageDownloader.Download("BigPic_1.jpg", "https://get.wallhere.com/photo/" +
    "landscape-mountains-lake-nature-reflection-grass-sky-river-national-" +
    "park-valley-wilderness-Alps-tree-autumn-leaf-mountain-season-tarn-lo" +
    "ch-mountainous-landforms-mountain-range-590185.jpg");
Console.WriteLine("Press any key to exit");
Console.Read();