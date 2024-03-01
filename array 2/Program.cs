using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo con los elementos dados
        int[] array = { 8, 43, 17, 6, 40, 16, 18, 97, 11, 7 };

        Console.WriteLine("Array original:");
        PrintArray(array);
        // Aplicar el algoritmo de ordenación Quicksort
        QuickSort(array, 0, array.Length - 1);
        Console.WriteLine("\nArray ordenado con Quicksort:");
        PrintArray(array);
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            // Aplicamos Quicksort recursivamente a los subarreglos generados en la partición
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(ref arr[i], ref arr[j]);
            }
        }

        Swap(ref arr[i + 1], ref arr[high]);
        return i + 1;
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

