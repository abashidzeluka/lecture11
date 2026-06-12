namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [45, 4, 32, 3, 64, 45];

            Array array = new Array(nums);

            Console.WriteLine(array.EqualToValue(45));
            Console.WriteLine("Unique numbers: " + array.CountDistinct());
        }
    }
}
