using System.Diagnostics;
using LR1;

static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введіть розмір даних:");
            int size = int.Parse(Console.ReadLine());
            Sort sort = new Sort();
            List<Animal> animals = RandomData.GenerateRandomData(size);
        
            Stopwatch casualSort = new Stopwatch();
            casualSort.Start();
            sort.SortByBreed(animals);
            sort.SortByAge(animals);
            sort.SortByType(animals);
            casualSort.Stop();
            Console.WriteLine($"Casual sort : {casualSort.ElapsedMilliseconds} ms");
        
            animals = RandomData.GenerateRandomData(size);
            Stopwatch singleThreadSort = new Stopwatch();
            singleThreadSort.Start();
            sort.SortBreedWithThread(animals);
            sort.SortAgeWithThread(animals);
            sort.SortTypeWithThread(animals);
            singleThreadSort.Stop();
            Console.WriteLine($"Single Thread : {singleThreadSort.ElapsedMilliseconds} ms");
            
            animals = RandomData.GenerateRandomData(size);
            Stopwatch multiThreadSort = new Stopwatch();
            multiThreadSort.Start();
            sort.SortBreedWithThread(animals);
            sort.SortAgeWithThread(animals);
            sort.SortTypeWithThread(animals);
            multiThreadSort.Stop();
            Console.WriteLine($"Multi thread sort :  {multiThreadSort.ElapsedMilliseconds} ms");
            
    }
    }

    
