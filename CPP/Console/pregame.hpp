#ifndef PRE_GAME
#define PRE_GAME

#include "gamedata.hpp";

namespace NumberBomb
{
    //A class contains all setting for the game
    class pregame
    {
    private:
        //Setup and get the maxmium number
        //There are 3 difficulties for different range of number
        int genMax(int diff)
        {
            switch (diff)
            {
                case 1:
                    return 100;
                case 2:
                    return 250;
                case 3:
                    return 500;
                default:
                    break;
            }
            return 0;
        };
        //Generate "lucky" number
        int genLuck(int max)
        {
            int temp = 0;

            return temp;
        }

    public:
        //Constructor for pregame class (Initalizing)
        pregame();
        //Constructor but another round
        pregame(int preLuck);
        //Run setup for a game
        void gamesetup();
    };
}

#endif