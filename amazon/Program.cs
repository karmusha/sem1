int[] array = new int[] {
    46,
    18,
    5,
    41,
    83,
    38,
    28,
    32,
    32,
    37,
};

// int[] array = new int[] {
//     1,
//     2,
//     3,4,5,6,7,8,9,10
// };

var sum_res = 5;

var res = new List<int>();

var sum = 0;

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length; j++)
    {
        sum = array[i] + array[j];
        res = new List<int>();
        res.Add(array[i]);
        res.Add(array[j]);

        for (int k = 0; k < array.Length; k++)
        {
            if (k != i && k != j)
            {
                sum = sum + array[k];
                res.Add(array[k]);
            }

            if (sum == sum_res)
            {
                Console.WriteLine($"sum = {sum}");
                Console.WriteLine($"res = {String.Join(", ", res.Select(x => x.ToString()).ToArray())}");
            }

            Console.WriteLine($"{sum}; {String.Join(", ", res.Select(x => x.ToString()).ToArray())}");
        }
    }
}