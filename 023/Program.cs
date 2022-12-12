            int [] GetUserArray (int length, int start, int end)
            {
                Console.Write("Введите число М (количество вводимых чисел): ");

                length = int.Parse(Console.ReadLine());
                int [] array = new int [length];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Введите элемент массива под индексом {i}: ");
                    array[i] = int.Parse(Console.ReadLine());                    
                }
                return array;
                
            }
            void PrintArray(int [] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }

            int NumberOfPositiv (int [] array)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        count++;
                    }
                }
                return count;
            }

            int [] newArray = GetUserArray(5,-10, 10);
            Console.WriteLine();
            PrintArray(newArray);
            int countNumber = NumberOfPositiv(newArray);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine ($"Количество положительных чисел, введенных пользователем = {countNumber}");
            Console.ResetColor();
            Console.WriteLine();