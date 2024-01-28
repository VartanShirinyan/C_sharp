// Четыре вида методов:
// Вид 1 - не принимают ни каких аргументов и ни чего не возвращают. 

//Method();
void Method()
{
    Console.WriteLine("Автор Вартан Ш.");
}




//Вид 2 - принимают какие то аргументы, но ничего не возвращают.

//Method2("Текст сообщения");
void Method2(string msg) // - в скобках это аргументы
{
    Console.WriteLine(msg);
}


//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: " Новый текст"); // или так
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}


// Вид 3 - ничего не принимают, но что-то возвращают.
// если метод, что то возврощае, то необходимо указать тип данных значения которых мы ожидаем

// int year = Method3();
// int Method3()
// {
//     return DateTime.Now.Year; //обязательное использование оператора "return"
// }
// Console.WriteLine(year);



// Вид 4 - что-то принимают, что-то возвращают.

// string res = Method4(10, "qwerty ");
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // String.Empty - ПУСТАЯ СТОРОКА
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// Console.WriteLine(res);




// Циклы и не только while

// string res = Method4(10, "qwerty ");
// string Method4(int count, string text)
// {

//     string result = String.Empty; // String.Empty - ПУСТАЯ СТОРОКА
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
//Console.WriteLine(res);



//Калькулятор
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


//====== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаяСь, - что,"
//             + "ежели бы вас послали вместо нашего милого Винцегероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012345
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }


//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);


// алгоритм методом сортировки

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length -1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }


//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }


        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);