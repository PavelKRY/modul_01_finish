// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = new string[5];
int j = 0;
int arrayFinalyLenght = 0;

int FillArrayAndSearchLenghtFinalyArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите пожалуйста значние");
        array[i] = Console.ReadLine();
        char[] tmp = array[i].ToCharArray();
        int temprary;
        temprary = tmp.Length;
        Console.WriteLine("Количество символов в строке = " + temprary);
        if (temprary <= 3)
        {
            arrayFinalyLenght++;
        }
    }
    return arrayFinalyLenght;
}
FillArrayAndSearchLenghtFinalyArray(array);
void PrintResultMetodOne()
{
Console.WriteLine(string.Empty);
Console.WriteLine("Количество строк, где количество символов меньше или равно трём = " + arrayFinalyLenght);
Console.WriteLine(string.Empty);
}
PrintResultMetodOne();
while (arrayFinalyLenght == 0)
{
    Console.WriteLine("Нужно ввести значения, хотя бы одно из которых состоит из трёх символов, в противном случае программа перезапустится");
    FillArrayAndSearchLenghtFinalyArray(array);
};
PrintResultMetodOne();



