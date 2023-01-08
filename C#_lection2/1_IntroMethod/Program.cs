// Максимальное из 9 чисел, сначала стихийно потом методом (функции).
int Max(int argument1, int argument2, int argument3)
{
    int result = argument1;
    if (argument2 > result) result = argument2;
    if (argument3 > result) result = argument3;
    return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 3700;
int a2 = 34;
int b2 = 33;
int c2 = 77;
int a3 = 56;
int b3 = 97552;
int c3 = 38;

// Способ СТИХИЙНЫЙ.
/* 
int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;       
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WraitLine(max);
*/
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(
          Max(a1, b1, c1),
          Max(a2, b2, c2),
          Max(a3, b3, c3));

Console.WriteLine(max);