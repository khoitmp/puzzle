public class EvenNumber
{
    public static void Run()
    {
        var nums = new List<int> { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10 };

        foreach (var num in nums)
        {
            if (num % 2 == 0)
                nums.Remove(num);
        }
    }
}