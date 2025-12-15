using System;
using MetodosOrdenamiento;

class Program
{
    static void Main()
    {
        int[] datos = { 45, 12, 78, 34, 23, 9, 56 };
        int opcion;

        Console.WriteLine("Arreglo original:");
        MostrarArreglo(datos);

        Console.WriteLine("\nSeleccione el método de ordenamiento:");
        Console.WriteLine("1. Bubble Sort");
        Console.WriteLine("2. Insertion Sort");
        Console.WriteLine("3. Heap Sort");
        Console.Write("Opción: ");
        opcion = int.Parse(Console.ReadLine());

        int[] copia = (int[])datos.Clone();

        switch (opcion)
        {
            case 1:
                Ordenamientos.BubbleSort(copia);
                Console.WriteLine("\nOrdenado con Bubble Sort:");
                break;

            case 2:
                Ordenamientos.InsertionSort(copia);
                Console.WriteLine("\nOrdenado con Insertion Sort:");
                break;

            case 3:
                Ordenamientos.HeapSort(copia);
                Console.WriteLine("\nOrdenado con Heap Sort:");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                return;
        }

        MostrarArreglo(copia);
        Console.ReadKey();
    }

    static void MostrarArreglo(int[] arreglo)
    {
        foreach (int num in arreglo)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
