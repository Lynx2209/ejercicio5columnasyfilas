namespace ejercicio5aritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabla = new int[3, 2];

            Random numeroRamdom = new Random();

            Console.WriteLine("Tabla original");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 2; columna++)
                {

                    tabla[fila, columna] = numeroRamdom.Next(1, 100);
                    Console.Write(tabla[fila, columna] + " ");

                }
                Console.WriteLine();

            }

            for (int columna = 0; columna < 2; columna++)
            {
                int[] columnaArray = new int[3];

                for (int fila = 0; fila < 3; fila++)
                {
                    columnaArray[fila] = tabla[fila, columna];
                }

                Array.Sort(columnaArray);

                for (int fila = 0; fila < 3; fila++)
                {
                    tabla[fila, columna] = columnaArray[fila];
                }
            }


            Console.WriteLine("Tabla ordenada:");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 2; columna++)
                {
                    Console.Write(tabla[fila, columna] + " ");
                }
                Console.WriteLine();
            }


            int valorMinimo = tabla[0, 0];
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 2; columna++)
                {
                    if (tabla[fila, columna] < valorMinimo)
                    {
                        valorMinimo = tabla[fila, columna];
                    }
                }
            }
            Console.WriteLine("El Valor mínimo es: " + valorMinimo);


            Console.WriteLine(" Los Valores máximos de cada una de las columnas:");
            for (int columna = 0; columna < 2; columna++)
            {
                int valorMaximo = tabla[0, columna];
                for (int fila = 1; fila < 3; fila++)
                {
                    if (tabla[fila, columna] > valorMaximo)
                    {
                        valorMaximo = tabla[fila, columna];
                    }
                }
                Console.WriteLine("Columna " + (columna + 1) + ": " + valorMaximo);
            }


            Console.WriteLine("Medias aritméticas de cada una de las filas:");
            for (int fila = 0; fila < 3; fila++)
            {
                int suma = 0;
                for (int columna = 0; columna < 2; columna++)
                {
                    suma += tabla[fila, columna];
                }
                double media = (double)suma / 2;
                Console.WriteLine("Fila " + (fila + 1) + ": " + media);
            }
        }
    }
}