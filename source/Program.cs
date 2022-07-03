

// задаю заданный условием массив с имеющимеся значениями
string[] Array = new string[] {"hello", "2", "world", ":-)"}; // ок, работает на выходе [ 2 :-)   ].

//проводим тестирование на других данных
//string[] Array = new string[] {"1234", "1567", "-2", "computer science"}; // ок, работает на выходе [ -2    ].
//string[] Array = new string[] {"Russia", "Denmark", "Kazan"}; // ок, работает на выходе [    ].

// создаю новый массив в который будут складываться нужные значения. Длинна нового массив равна длинне заданного массива Array
string[] NewArray = new string [Array.Length];

// метод сканирования массива на наличие элементов <= 3 символам.
void MetodNewArray (string [] array, string [] newarray)
{
    int index = 0;
    for (int i = 0; i < Array.Length; i++)
        {
            if (array[i].Length < 4)
            {
                // если удовлетворяет условие, то в элемент index массива newarray складывается нужный элемент array[i] и прибавляем индекс
                newarray[index] = array[i];
                index++;
            }
        }
}

//Метод печати массива
void PrintArray (string [] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }


Console.WriteLine("Заданый массив");
PrintArray(Array);
MetodNewArray(Array, NewArray);
Console.WriteLine("Обработанный массив");
PrintArray(NewArray);