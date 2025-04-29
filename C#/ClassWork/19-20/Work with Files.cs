//// создаст файл в нужной директории
//var path = "C:\\Users\\TitanPC\\Desktop\\Дипломы\\test.txt";


//// если передать просто название файла,то создаст файл там, где лежит проект
//var path2 = "test.xml";

//while(true)
//{ 
//    Console.WriteLine("1: чтение из файла");
//    Console.WriteLine("2: запись в файл");

//    var value = int.Parse(Console.ReadLine());
//    if(value == 1)
//    {
//        using var fileStream =  new FileStream(path, FileMode.Open,FileAccess.Read);
//        using var streamReader = new StreamReader(fileStream);
//        string line;
//        while ((line = streamReader.ReadLine())!=null)
//        {
//            Console.WriteLine(line);
//        }
//    }
//    else if(value == 2)
//    {
//        var data = Console.ReadLine();
//        // FileMode.Append дозаписывает данные в файл
//        using var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
//        using var streamWriter = new StreamWriter(fileStream);
//        streamWriter.WriteLine(data);
//    }
//}