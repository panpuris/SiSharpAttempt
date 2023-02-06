
// Работа с директориями
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

void CatalogInfo(string path, string indent = "")                 //  в качестве 1го аргумента принимается путь к папке, 2ой аргумент это искуственный отступ
{
    DirectoryInfo catalog = new DirectoryInfo(path);              // получение информации от директории в которую заходим

    DirectoryInfo[] catalogs = catalog.GetDirectories();          // получение массива всех файлов находящихся внутри папки
    for (int i = 0; i < catalogs.Length; i++)                     // пробегая по всем им 
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");  // вывод информации текщего каталога и его содержимом
        CatalogInfo(catalogs[i].FullName, indent + " ");          // рекурсивный вход во все папки каталога
    }
    FileInfo[] files = catalog.GetFiles();                        // получение полного списка файлов текущей директории

    for (int i = 0;i<files.Length;i++)                             
    {
        System.Console.WriteLine($"{indent}{files[i].Name}");     // вывод информации по файлам
    }

}
string path = "C:/Users/Misha/Desktop/GeekBrains/C#/Examples/examples_array_methods"; // путь к каталогу
CatalogInfo(path);