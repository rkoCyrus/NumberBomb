#ifndef GAMEDATA_H
#define GAMEDATA_H
#define RAND_MAX = 65535
#include <random>
#include <time.h>
#include "ingame.hpp"
namespace NumberBomb
{
    class Gamedata : public Ingame
    {
    private:
        //Pick a number for loading "Lucky Number"
        int luckNum;
        //Previous lucky number
        int preLuckNum;
        //Check does user decide to play this game or not
        bool isPlay;
        //Generate lucky number
        void genLuck()
        {
            do
            {
                srand(time(NULL));
                luckNum = rand()%maxNum;
            }
            while (luckNum==preLuckNum||luckNum<=1);
        }
    protected:
        //Maximum number in a range of number
        int maxNum;
        //Get lucky number for ingame (via pregame)
        int getLuck()
        {
            genLuck();
            return luckNum;
        }
    public:
        Gamedata();
        Gamedata(int);
        bool playing()
        {
            return isPlay;
        }
        void endgame()
        {
            isPlay = false;
        }
    };
    
    //Initial game
    Gamedata::Gamedata()
    {
        isPlay = true;
        this->preLuckNum = 0;
        
    }

    //Next round of the game
    Gamedata::Gamedata(int preLuckNum)
    {
        isPlay = true;
        this->preLuckNum = preLuckNum;
    }
    
}
#endif