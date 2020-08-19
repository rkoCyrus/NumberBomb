#include <stdlib.h>
#include <time.h>
#ifndef GAME_VALUE
#define GAME_VALUE

struct GameValue
{
    int range[2];
    int luckNum;
};

#endif

//Generate luckyNumber
int genLuckNum(int max)
{
    srand(time(0));
    int result = 0;
    do
    {
        result = rand();
        if (result>=max)
        {
            result %= max;
        }
    } while (result<=1);
    return result;
}