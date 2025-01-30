
namespace _01_C_Advanced
{
    internal class Range<T> where T : struct, IComparable<T>
    {
         T min;
         T max;
        public Range(T min, T max)
        {
            this.min = min;
            this.max = max;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }

        public double Length()
        {
            return Convert.ToDouble(max) - Convert.ToDouble(min);
        }
    }
}
