using System;

class GenericArray<T>
{
    private T[] array;
    private int size;

    public GenericArray(int capacity)
    {
        array = new T[capacity];
        size = 0;
    }

    public void Add(T item)
    {
        if (size < array.Length)
        {
            array[size] = item;
            size++;
        }
        else
        {
            Console.WriteLine("Массив заполнен. Не удается добавить больше элементов.");
        }
    }

    public bool RemoveAt(int index)
    {
        if (index >= 0 && index < size)
        {
            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            size--;
            return true;
        }
        else
        {
            Console.WriteLine("Неверный индекс. Элемент не удален.");
            return false;
        }
    }

    public T GetElementAt(int index)
    {
        if (index >= 0 && index < size)
        {
            return array[index];
        }
        else
        {
            Console.WriteLine("Неверный индекс. Возвращает значение по умолчанию.");
            return default(T);
        }
    }

    public int Length()
    {
        return size;
    }
}

class Program
{
    static void Main(string[] args)
    {
        GenericArray<int> intArray = new GenericArray<int>(5);
        intArray.Add(10);
        intArray.Add(20);
        intArray.Add(30);

        Console.WriteLine("Целочисленный массив:");
        for (int i = 0; i < intArray.Length(); i++)
        {
            Console.WriteLine(intArray.GetElementAt(i));
        }

        GenericArray<string> stringArray = new GenericArray<string>(5);
        stringArray.Add("Hello");
        stringArray.Add("World");

        Console.WriteLine("\nМассив строк:");
        for (int i = 0; i < stringArray.Length(); i++)
        {
            Console.WriteLine(stringArray.GetElementAt(i));
        }

        GenericArray<double> doubleArray = new GenericArray<double>(5);
        doubleArray.Add(3.14);
        doubleArray.Add(2.718);

        Console.WriteLine("\nМассив с плав. точкой:");
        for (int i = 0; i < doubleArray.Length(); i++)
        {
            Console.WriteLine(doubleArray.GetElementAt(i));
        }
    }
}
