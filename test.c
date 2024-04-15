#include <stdio.h>
#include "test.h"
#define A 10
int main()
{
    int a = 5;
    int b = 3;
    int result = sum(&a, &b);
    if (result == 8)
        return 0;
    else
        return 1;
}
