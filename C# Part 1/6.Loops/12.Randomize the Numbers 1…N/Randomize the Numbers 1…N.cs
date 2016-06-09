using System;
class RandomizetheNumbers1N
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] array = new int[num];

        for (int i = 0; i < num; i += 1)
        {
            array[i] = i + 1;
        }

        Random random = new Random();

        foreach (int index in array)
        {
            int randNum = random.Next(0, num);
            int temp = array[randNum];
            array[randNum] = array[0];
            array[0] = temp;
        }
        Console.WriteLine(String.Join(" ", array));

    }
}