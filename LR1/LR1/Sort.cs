namespace LR1;

public class Sort
{
    public void SortByBreed(List<Animal> animals)
    {
        animals.Sort((a, b) => a.Breed.CompareTo(b.Breed));
    }
    
    public void SortByType(List<Animal> animals)
    {
        animals.Sort((a, b) => a.Type.CompareTo(b.Type));
    }
    public void SortByAge(List<Animal> animals)
    {
        animals.Sort((a, b) => a.Age.CompareTo(b.Age));
    }
    
    public void SortBreedWithThread(List<Animal> animals)
    {
        Thread thread = new Thread(() => SortByBreed(animals));
        thread.Start();
        thread.Join();
    }
    public void SortTypeWithThread(List<Animal> animals)
    {
        Thread thread = new Thread(() => SortByType(animals));
        thread.Start();
        thread.Join();
    }
    public void SortAgeWithThread(List<Animal> animals)
    {
        Thread thread = new Thread(() => SortByAge(animals));
        thread.Start();
        thread.Join();
    }
    
    public void SortMultiThreaded(List<Animal> animals)
    {
        Thread thread1 = new Thread(() => SortByType(animals));
        Thread thread2 = new Thread(() => SortByAge(animals));
        Thread thread3 = new Thread(() => SortByBreed(animals));

        thread1.Start();
        thread2.Start();
        thread3.Start();
        
        thread1.Join();
        thread2.Join();
        thread3.Join();
    }
    
}