#include <stdio.h>
#include "test.h"
// #include "sum.c"
#define A 10
int main()
{
    int a = 5;
    int b = 3;
    int result = sum(&a, &b);
    printf("Definition: %d\n", A);
    printf("Tong cua %d va %d la %d\n", a, b, result);
    return 0;
}
