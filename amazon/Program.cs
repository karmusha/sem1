int[] array = new int[] {
    966,
    46,
    198,
    129,
    97,
    14,
    140,
    53,
    92,
    105,
    21,
    673,
    15,
    375,
    100,
    122,
    2579,
    264,
    292,
    184,
    15,
    23,
    439,
    826,
    46,
    534,
    138,
    161,
    61,
    183,
    6,
    549,
    124
};

// int[] array = new int[] {
//     1,
//     2,
//     3,4,5,6,7,8,9,10
// };

var sum_res = 9343;

var res = new List<int>();

var sum = 0;

for (int i = 0; i < array.Length; i++) {
    for (int j = 0; j < array.Length; j++) {
        sum = array[i] + array[j];
        res = new List<int>();
        res.Add(array[i]);
        res.Add(array[j]);

        for (int k = 0; k < array.Length; k++) {
            if (k != i && k != j) {
                sum = sum + array[k];
                res.Add(array[k]);
            }

            if (sum == sum_res) {
                Console.WriteLine($"sum = {sum}");
                Console.WriteLine($"res = {String.Join(", ", res.Select(x => x.ToString()).ToArray())}");
            }

            Console.WriteLine($"{sum}; {String.Join(", ", res.Select(x => x.ToString()).ToArray())}");
        }
    }
}