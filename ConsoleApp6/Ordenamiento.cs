namespace MetodosOrdenamiento
{
    internal class Ordenamientos
    {
        public static void BubbleSort(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }
        }

        public static void InsertionSort(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arreglo[i];
                int j = i - 1;

                while (j >= 0 && arreglo[j] > key)
                {
                    arreglo[j + 1] = arreglo[j];
                    j--;
                }
                arreglo[j + 1] = key;
            }
        }

        public static void HeapSort(int[] arreglo)
        {
            int n = arreglo.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arreglo, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = arreglo[0];
                arreglo[0] = arreglo[i];
                arreglo[i] = temp;

                Heapify(arreglo, i, 0);
            }
        }

        private static void Heapify(int[] arreglo, int n, int i)
        {
            int mayor = i;
            int izquierda = 2 * i + 1;
            int derecha = 2 * i + 2;

            if (izquierda < n && arreglo[izquierda] > arreglo[mayor])
                mayor = izquierda;

            if (derecha < n && arreglo[derecha] > arreglo[mayor])
                mayor = derecha;

            if (mayor != i)
            {
                int temp = arreglo[i];
                arreglo[i] = arreglo[mayor];
                arreglo[mayor] = temp;

                Heapify(arreglo, n, mayor);
            }
        }
    }
}
