// 4 типа методов


// Вид 1 - ничего не принимает, ничего не возвращает (просто сообщает)

// void Method1()
// {
//     Console.WriteLine("Автор проэкта ");
// }
// Method1();





// Вид 2 - что-то принимает, ничего не возвращает

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2("Текст сообщения"); - или:
// Method2(msg: "Текст сообщения");



// Вид 3 - ничего не принимает, что-то возвращает

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);



// Вид 4 - что-то принимает, что-то возвращает

// //                         char s    
// string Method4(int count, string s)
// {
//     int i = 0;
//     string result = String.Empty; // = ""
//     while (i < count)
//     {
//         result = result + s;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "abc, "); // 10 - это количество раз вывести на экран
// Console.WriteLine(res);



// Вид 4 - что-то принимает, что-то возвращает С ПОМОЩЬЮ ЦИКЛА FOR 

string Method4(int count, string s)
{
    string result = String.Empty; // = ""
    for (int i = 0; i < count; i++)
    {
        result = result + s;
    }
    return result;
}
string res = Method4(10, "abc, "); // 10 - это количество раз вывести на экран
Console.WriteLine(res);
