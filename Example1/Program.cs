// // МЕТОДЫ
// // Вид 1
// void Method1()
// {
//     Console.WriteLine("Author...");
// }
// Method1(); //вызываем метод

// // Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Text message"); //вызываем метод
// // Method2(msg: "Text message"); //вызываем метод с именованным аргументом

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21("Text", 4); //вызываем метод
// Method21(count: 3, msg: "New Text");  //вызываем метод с именованным аргументом, здесь не обяз. по порядку

// // Вид 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// // Вид 4
// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;

// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }
// // string res = Method4(5, "meowmeow");
// // Console.WriteLine(res);

// //цикл FOR
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(5, "meowmeow ");
// Console.WriteLine(res);

// //Цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j,2} = {i * j}"); //интерполяция строк
//     }
//     Console.WriteLine();
// }

// =============Задача=================================================
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.
// Ясна ли задача?
// ====================================================================

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого "
//             + "Винценгероде, вы бы взяли приступом согласие "
//             + "прусского короля. Вы так красноречивы. Вы "
//             + "дадите мне чаю? Спасибо";

// // string s = "qwerty";
// //             012345
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// //вызываем методы
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'K');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);


//Упорядочить массив - алгоритм сортировки методом выбора (мин, макс)
//6 8 3 2 1 4 5 7 //берём минимальное
//1 8 3 2 6 4 5 7 //и ставим на первое место, меняя местами с 6
//1 2 3 8 6 4 5 7 //из неотсортированного ищем мин, меняем местами с вторым [1] элементом массива

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // определим (заведём) массив

//метод для вывода массива на экран
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
    for (int i = 0; i < array.Length - 1; i++) //отняли 1 так как во внутр.цикле мы начинаем от i+1 и чтобы получить общее кол-во эл-тов отнимаем
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++) //ищем минимальное. уже отсортированное не смотрим
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        //обмен двух переменных местами
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);

//адаптировать этот код, чтобы упорядочивание производилось в обратном порядке от макс к мин.

void SelectionSort2(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) //отняли 1 так как во внутр.цикле мы начинаем от i+1 и чтобы получить общее кол-во эл-тов отнимаем
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++) //ищем максимальное. уже отсортированное не смотрим
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        //обмен двух переменных местами
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
SelectionSort2(arr);
PrintArray(arr);

// готово :)
// iMac-Olesya:Example1 oleskass$ dotnet run
// 1 5 4 3 2 6 7 1 1 
// 1 1 1 2 3 4 5 6 7 
// 7 6 5 4 3 2 1 1 1 