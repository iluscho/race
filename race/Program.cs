namespace race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carslength = 10; // Изменение количества машин

            int[] cars = new int[carslength];
            for (int counter = 0; counter < carslength; counter++)
            {
                cars[counter] = 100;
            }

            foreach (int i in cars) { Console.Write(i + " "); }
            Console.WriteLine();

            Turn1(cars);
            Turn2(cars);
            Turn3(cars);
            Turn4(cars);
        }

        static int[] Turn1(int[] cars)
        {
            Random random = new Random();  
            if (random.Next(1, 100) <= 30)
            {
                int id = random.Next(0, cars.Length);
                cars[id] = 0;
                Console.WriteLine($"Машина {id+1} мертва на 1 повороте");
            }
            else
            {
                Console.WriteLine($"Все живы");
            }
            foreach (int i in cars) { Console.Write(i + " "); }
            Console.WriteLine();
            return cars;
        }
        static int[] Turn2(int[] cars)
        {
            Random random = new Random();
            if (random.Next(1, 100) <= 60)
            {
                int id = random.Next(0, cars.Length);
                if (cars[id] == 0)
                {
                    Console.WriteLine($"Машина {id + 1} уже мертва, переигровка поворота 2");
                    Turn2(cars);
                }
                else
                {
                    cars[id] = 0;
                    Console.WriteLine($"Машина {id+1} мертва на 2 повороте");
                }
            }
            else
            {
                Console.WriteLine($"Все живы на 2 повороте");
            }
            foreach (int i in cars) { Console.Write(i + " "); }
            Console.WriteLine();
            return cars;
        }
        static int[] Turn3(int[] cars)
        {
            Random random = new Random();
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != 0)
                {
                    if (random.Next(1, 100) <= 40)
                    {
                        cars[i] = 0;
                        Console.WriteLine($"Машина {i + 1} мертва на 3 повороте, у неё не было оборудования");
                    }
                    else
                    {
                        Console.WriteLine($"Машина {i + 1} проехала 3 поворот");
                    }
                }
                else
                {
                    Console.WriteLine($"машина {i + 1} уже мертва не доехав до 3 поворота");
                }
            }
            foreach (int i in cars) { Console.Write(i + " "); }
            Console.WriteLine();
            return cars;
        }
        static int[] Turn4(int[] cars)
        {
            Random random = new Random();
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != 0)
                {
                    if (random.Next(1, 100) <= 20)
                    {
                        cars[i] = 0;
                        Console.WriteLine($"Машина {i + 1} не справилась со смертельным испытанием 4 поворота");
                    }
                    else
                    {
                        Console.WriteLine($"Машина {i + 1} проехала 4 поворот");
                    }
                }
                else
                {
                    Console.WriteLine($"машина {i + 1} уже мертва не доехав до 4 поворота");
                }
            }
            foreach (int i in cars) { Console.Write(i + " "); }
            Console.WriteLine();
            return cars;
        }
    }
}