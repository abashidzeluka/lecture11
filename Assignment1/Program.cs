namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [47, 83, 12, 65, 29, 91, 54, 38, 76, 7];

            Array array = new Array();

            array.ShowEven(nums);

            array.ShowOdd(nums);
        }
    }
}
