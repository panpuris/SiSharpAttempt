
//Мини проба фильма матрица

// Random r = new Random();
// Console.CursorVisible = false;
// while(true)
// {
//     Console.SetCursorPosition(
//         left: r.Next(Console.WindowWidth),
//         top: r.Next(Console.WindowHeight)
//     );
//     Console.Write(r.Next(10));
//     Thread.Sleep(1000);
// }

/// <param name = "text"> Это изначальный текст который потом мы переделаем text</param>
/// <param name = "data"> Это аргумент в который мы переводим текст data</param>


using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)" //возьмите текст
              .Replace("(", "")         //замените в нем одни скобочки
              .Replace(")", "")         //замените в нем другие скобочки
              ;
System.Console.WriteLine(text);

var data = text.Split(" ") //возьми текст и командой Split разбей его (в данном случае разделитель это пробел)
            .Select(item => item.Split(','))    //через команду Select сделай выборку элементов разбивки, где новым разделителем будет ","
            .Select(coordinat => (x: int.Parse(coordinat[0]), y: int.Parse(coordinat[1]))) //выборка из текщего массива где первый элемент будет конвертирован в int x [0], а второй элемент y[1]
            .Where(coordinat => coordinat.x % 2 == 0) //мы производим проверку условия где координата четная 
            .Select(point => (point.x * 10, point.y + 20)) // просим сделать увеличение координат x и y
            .ToArray(); //превращаем в массив

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}
//     for (int k=0; k < data[i].Length;k++)
//     {
//         System.Console.WriteLine(data[i][k]); ;
//     }
//     System.Console.WriteLine();
// }


