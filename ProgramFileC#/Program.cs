// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

//Метод общения с пользователем  - читает дынные от пользователя
string ReadData(string msg)
{
    Console.WriteLine(msg);
    string res = Console.ReadLine() ?? "0";
    return res;
}

// Метод заполнения одномерного массива
string[] Gen1DArr(int len)
{
    string[] res = new string[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = ReadData($"Введите строку в {i + 1}-ю ячейку массива:");
    }
    return res;
}

// Метод печати одномерного массива
void Print1DArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод создания массива с выборкой строк, длина которых меньше, либо равна 3 символам
string[] StrUpTo3Signs(string[] arr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++) // Цикл для поиска нужных строк и подсчета их количества
    {
        char[] checkSigns = arr[i].ToCharArray();
        if (checkSigns.Length <= 3) j++;
        else arr[i] = string.Empty;
    }

    string[] resArr = new string[j];
    int k = 0;
    for (int i = 0; i < arr.Length; i++) // Заполнение результирующего массива
    {
        if (arr[i] != string.Empty)
        {
            resArr[k] = arr[i];
            k++;
        }
    }
    return resArr;
}

// Ввод массива пользователем с выводом в консоль
int size = int.Parse(ReadData("Введите количество ячеек массива:"));
string[] userArray = Gen1DArr(size);
Console.Write($"Введенный вами массив: ");
Print1DArr(userArray);

// Ссоздание и вывод массива с выборкой строк
string[] finalArray = StrUpTo3Signs(userArray);
Console.Write($"Массив с выборкой строк, длина которых меньше, либо равна 3 символам: ");
Print1DArr(finalArray);