// // F(x) = X2 + 1

// double f(double x)
// {
//     double result = x * x + 1;
//     return result;
// }

// // --- --- ---

// int a1 = 15;
// int b1 = 1000;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 25;
// int c3 = 33;

// // --- 1 ---
// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;
// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;



// --- 2 ---
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

// // --- 3 ---
// int max = Max(
//     Max(a1, b1, c1), 
//     Max(a2, b2, c2), 
//     Max(a3, b3, c3));

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// Console.WriteLine (max);

// --- --- ---

//              0   1   2    3   4   5   6   7  8
int[] array = { 18, 2, 1000, 14, 54, 63, 7, 85, 9 };

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);