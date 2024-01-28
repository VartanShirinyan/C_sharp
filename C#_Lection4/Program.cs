﻿//Двумерные массивы
//Создание матрицы

// string[,] table = new string[2, 5];
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)     // for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }


// int[,] matrix = new int[3, 4];
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray(matrix);







//Заполнение матрицы случайными числами

// int[,] matrix = new int[3, 4];
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);//[1; 10)
//         }
//     }
// }

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);







//Закрашивание области

// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"*");
//         }
//         Console.WriteLine();
//     }
// }
// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);







// Рекурсия

// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(5)); // 1 * 2 * 3 = 6


// Double Factorial(int n)  // int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     // Console.WriteLine(Factorial(i));
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }






// Вычисление чисел Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}"); // Console.WriteLine(Fibonacci(i));
// }








// Тетрис

/*  Эта программа создана в рамах изучения языка программирования C#.
    Цель - закрепление навыков работы с двуменрными массивами.
    Игра не полноценная и носит характер "так тоже можно".
    По возможности, код дополнен комментариями.

    Упрощения принятые в игре:
    - вращени фигурок только в одну сторону
    - фигурки нельзя "ронять"
*/

// Тут мы опишем глобальные переменные, 
// которые будут использоваться по всей программе

// массив нашего стакана 12 х 16, внутренне пространство для игры 10 х 15
// в массиве приняты следющие обозначения:
// 0 - пусто, 1 - фигурка, 2 - стенка, 3 - "мусор" от падающих фигур
int[,] stakan = new int[12, 16];
// массив для хранения фигурки, в нем она же будет и "поворачиваться"
int[,] figura = new int[4, 4];
// переменные для хранения координат левого верхнего угла фигурки
int fx = 5;
int fy = 0;
// Переменная-флаг, сообщающая о том, что наступил "Конец игры"
bool endGame = false;
// переменная отвечающая за скорость опускания фигурки
// хранит время задержки между изменениями высоты в миллисекундах
int speed = 500;
// тут будем считать, сколько мы "продержались" в игре
int score = 0;

// тут у нас начинается собственно программа

// выключаем курсор, чтобы он не мешался на выводимом нами тексте
Console.CursorVisible = false;
// формируем "пустой" стакан специальным методом
stakan = GetNewStakan();
// выводим на экран наш стакан
Console.Clear();
PrintStakan();
// генерируем новую случайную фигурку
figura = GetNewFigure();
// выводим фигуру на экран
PrintFigure(fx, fy);

// отдельный поток программы, отвечающий за опускание фигурки по времени
new Thread(() =>
{
    while (!endGame)
    {
        // раз "продержались" еще один цикл программы, то добавим себе победных очков
        score++;
        // выводим на экран параметры игры
        PringGameParameters();
        // просим этот поток программы "заснуть" на определенное время
        Thread.Sleep(speed);
        // прежде чем опустить фигурку ниже, проверяем есть ли куда ее опускать
        if (!GetFigureConflict(figura, fx, fy + 1))
        {
            // стираем фигурку, увеличиваем координату и рисуем ее на новом месте
            EraseFigure(fx, fy);
            fy += 1;
            PrintFigure(fx, fy);
        }
        else
        {
            // оказалось, что наша фигурка уже с чем-то столкнулась
            // стираем фигурку
            EraseFigure(fx, fy);
            // переводим фигурку в "мусор" в стакане
            SetFigureToStakan(figura, fx, fy);
            // проверяем, нет ли заполненных строк у нас в стакане
            // и при необходимости убираем их
            CheckLineInStakan();
            // обновляем стакан на экране
            PrintStakan();
            // генерируем новую фигурку
            figura = GetNewFigure();
            // устанавливаем координаты новой фигурки вверх и середину стакана
            fx = 5;
            fy = 0;
            // теперь надо проверить, а новая фигурка помещается в наш стакан
            // или стакан уже "забит" доверху?
            if (GetFigureConflict(figura, fx, fy))
            {
                // если некуда разместить новую фигурку, то сообщаем всем, что игра закончена
                endGame = true;
                break;
            }
            else
            {
                // если место под новую фигурку свободно
                // выводим на экран новую фигурку
                PrintFigure(fx, fy);
            }
        }
    }
}).Start();


// основной цикл программы, в котором мы обрабатываем нажатия клавиш на клавиатуре
// делаем это до тех пор, пока не наступит ситуация, что игра закончилась
while (!endGame)
{
    // получаем с клавиатуры код нажатой клавиши
    var key = Console.ReadKey(true).Key;
    // в зависимости от нажатой клавиши, делаем нужные нам действия
    switch (key)
    {
        // нажата стрелка влево
        case ConsoleKey.LeftArrow:
            // проверяем, не пересекается ли фигура на новом месте со стенкой или остатками других фигур
            if (!GetFigureConflict(figura, fx - 1, fy))
            {
                EraseFigure(fx, fy);
                fx -= 1;
                PrintFigure(fx, fy);
            }
            break;
        // нажата стрелка вправо
        case ConsoleKey.RightArrow:
            // проверяем, не пересекается ли фигура на новом месте со стенкой или остатками других фигур
            if (!GetFigureConflict(figura, fx + 1, fy))
            {
                EraseFigure(fx, fy);
                fx += 1;
                PrintFigure(fx, fy);
            }
            break;
        // нажата стрелка вверх
        case ConsoleKey.UpArrow:
            // проверяем, не пересекается ли фигура при повороте со стенкой или остатками других фигур
            if (!GetFigureConflict(GetRotateFigure(figura), fx, fy))
            {
                EraseFigure(fx, fy);
                figura = GetRotateFigure(figura);
                PrintFigure(fx, fy);
            }
            break;
        // по кнопке Q (quit) выходим из игры
        case ConsoleKey.Q:
            endGame = true;
            break;
        // По кнопке [+] увеличиваем задержку между шагами опускания фигурки, на 100 миллисекунд
        case ConsoleKey.OemPlus:
            if (speed < 2000) speed += 100;
            PringGameParameters();
            break;
        // По кнопке [-] уменьшаем задержку между шагами опускания фигурки, на 100 миллисекунд
        case ConsoleKey.OemMinus:
            if (speed > 200) speed -= 100;
            PringGameParameters();
            break;
        default:
            break;
    }
}

// делаем курсор видимым, чтобы можно было вводить данные в терминал
Console.CursorVisible = true;
Console.SetCursorPosition(1, 17);
Console.WriteLine("Конец игры...  ");


// ===========================================================================
// ===========================================================================
// А тут у нас будут методы, необходимые для работы нашей программы

// Метод, формирующий "чистый" стакан для нашего тетриса
// массив для стакана 12 х 16 элементов
int[,] GetNewStakan()
{
    int[,] stak = new int[,]
    {
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
    {2, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 2 },
    {2, 3, 0, 3, 0, 0, 0, 3, 0, 0, 0, 2 },
    {2, 3, 3, 3, 0, 3, 3, 3, 0, 3, 0, 2 },
    {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
    };
    return stak;
}

// Получаем случайную фигурку из заранее описанного набора фигурок
int[,] GetNewFigure()
{
    int[,] stak;
    Random rnd = new Random();
    int s = rnd.Next(1, 5);
    switch (s)
    {
        case 1:
            // перевернутая буква Т
            stak = new int[,] { { 0, 0, 1, 0 }, { 0, 1, 1, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            break;
        case 2:
            // квадратик
            stak = new int[,] { { 0, 0, 0, 0 }, { 0, 1, 1, 0 }, { 0, 1, 1, 0 }, { 0, 0, 0, 0 } };
            break;
        case 3:
            // вертикальная палочка
            stak = new int[,] { { 0, 0, 1, 0 }, { 0, 0, 1, 0 }, { 0, 0, 1, 0 }, { 0, 0, 1, 0 } };
            break;
        case 4:
            // буква Г
            stak = new int[,] { { 0, 1, 1, 0 }, { 0, 1, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };
            break;
        case 5:
            // зигзаг Z
            stak = new int[,] { { 0, 1, 1, 0 }, { 0, 0, 1, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            break;
        default:
            // по умолчанию - квадратик
            stak = new int[,] { { 0, 0, 0, 0 }, { 0, 1, 1, 0 }, { 0, 1, 1, 0 }, { 0, 0, 0, 0 } };
            break;

    }
    return stak;
}


// выводим массив на экран
// в массиве приняты следющие обозначения:
// 0 - пусто, 1 - фигурка, 2 - стенка, 3 - "мусор" от падающих фигур
// так как символы у нас вытянутые, то мы какждый элемент массива выводим как два символа
// в результате получатся "квадратные" блоки
void PrintStakan()
{
    // перебираем строки массива
    for (int i = 0; i < 16; i++)
    {
        // перебираем столбцы массива
        for (int j = 0; j < 12; j++)
        {
            // если в массиве что-то есть для отображения
            if (stakan[i, j] != 0)
            {
                // устанавливаем курсор на экране в нужное место
                Console.SetCursorPosition(j * 2, i);
                switch (stakan[i, j])
                {
                    // фигурка
                    case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[]");
                        break;
                    // стенка
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("██");
                        break;
                    // мусор
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("[]");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
// выводим на экран нашу фигурку, по указанным координатам
void PrintFigure(int x, int y)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (figura[i, j] > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition((x + j) * 2, y + i);
                Console.Write("[]");
            }
        }
    }
}

// чтобы не перерисовывать весь стакан, "стираем" только фигурку
// под "стираем", подразумеваем "запечатывание" пробелами, они же для нас "невидимые"
void EraseFigure(int x, int y)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (figura[i, j] > 0)
            {
                Console.SetCursorPosition((x + j) * 2, y + i);
                Console.Write("  ");
            }
        }
    }
}

// метод проверки, не пересекается ли фигура на новом месте со стенкой 
// или остатками других фигур в стакане 
bool GetFigureConflict(int[,] f, int x, int y)
{
    bool conflict = false;
    // перебираем массив с фигуркой
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            // если у нас получилось наложение ненулевых значений, 
            // то это означает наложение фигурки на содержимое стакана
            if (f[j, i] != 0)
                if (stakan[y + j, x + i] != 0)
                {
                    conflict = true;
                    break;
                }
        }
        // чтобы дальше не перебирать фигурку, выходим из цикла
        if (conflict) break;
    }
    return conflict;
}

// метод поворота фигуры на 90 градусов
int[,] GetRotateFigure(int[,] f)
{
    int[,] nf = new int[4, 4];
    // для поворота переносим ячейки в нужном порядке
    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++)
            nf[3 - j, i] = f[i, j];
    return nf;
}

// метод перевода фигурки в "мусор" в стакане
void SetFigureToStakan(int[,] f, int x, int y)
{
    // перебираем все элементы фигурки и все 1 из нее переводим в 3 в массиве стакана
    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++)
            if (f[j, i] != 0)
                stakan[y + j, x + i] = 3;
}

void CheckLineInStakan()
{
    bool checkLine = true;
    int count = 0;
    while (checkLine)
    {
        checkLine = false;
        // перебираем все строки в стакане
        for (int i = 0; i < 15; i++)
        {
            // считаем число заполненных ячеек в строке
            count = 0;
            for (int j = 1; j < 11; j++)
            {
                if (stakan[i, j] > 0) count++;
            }
            // если нашли заполненную строку, то нужно её "сократить"
            // путем помещения на 1 строку вниз значений из верхних строк
            if (count == 10)
            {
                // пербираем все строки "снизу вверх"
                for (int k = i; k > 0; k--)
                {
                    // в каждую строку копируем значение с верхней строки
                    for (int n = 1; n < 11; n++)
                    {
                        stakan[k, n] = stakan[k - 1, n];
                    }

                }
                // очищаем экран
                Console.Clear();
                // выводим на экран обновленный стакан, без сокращенной строки
                PrintStakan();
                // говорим что надо еще раз проверить на полную линию, вдруг у нас их сразу несколько
                checkLine = true;
            }
        }
    }
}

// метод вывода на экран дополнительной информации об игре
void PringGameParameters()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(30, 1);
    Console.WriteLine("Учебный ТЕТРИС");
    Console.SetCursorPosition(30, 4);
    Console.WriteLine($"Текущая скорость: {speed}  ");
    Console.SetCursorPosition(30, 6);
    Console.WriteLine($"Набрано очков: {score}  ");
    Console.SetCursorPosition(30, 8);
    Console.WriteLine("Влево-вправо - стрелками");
    Console.SetCursorPosition(30, 10);
    Console.WriteLine("Крутить - стрелка вверх");
    Console.SetCursorPosition(30, 12);
    Console.WriteLine("[+] и [-] - изменение скорости");
    Console.SetCursorPosition(30, 14);
    Console.WriteLine("[Q] - выход из игры");
}