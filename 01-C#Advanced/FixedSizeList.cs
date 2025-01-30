
namespace _01_C_Advanced
{
    internal class FixedSizeList<T>
    {
        private T[] numbers;
        private int counter;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                Console.WriteLine("Invalid");
                capacity = 1;
            }
            numbers = new T[capacity];
            counter = 0;
        }

        public void Add(T item)
        {
            if (counter >= numbers.Length)
            {
                Console.WriteLine("List is complete.");
                return;
            }
            numbers[counter] = item;
            counter++;
        }

        public T? Get(int index)
        {
            if (index < 0 || index >= counter)
            {
                Console.WriteLine("Invalid.");
                return default;
            }
            return numbers[index];
        }

        public int Count()
        {
            return counter;
        }

        public int Capacity()
        {
            return numbers.Length;
        }

    }
}
