#ifndef GAME_DATA
#define GAME_DATA

namespace NumberBomb
{
    //Storing user setted data and variablefor the game
    class gamedata
    {
    private:
        //Lucky number :)))))
        int luckNum;
        //Range of the game
        int maxRange, minRange;
        //Previous luckyNumber to enhance randomizing result
        int preLuck;
    public:
        gamedata();
        gamedata(int preLuck);
    };
    
    gamedata::gamedata()
    {
        this->preLuck = 0;
    }

    gamedata::gamedata(int preLuck)
    {
        this->preLuck = preLuck;
    }

    //For maintaining game process which only buunch of boolean there
    class gamefunction
    {
        public:
            //Check is user want to play
            static bool isPlay;
            //Check is user executed or loop back 
            static bool firstRun;
            //Constructor
            gamefunction();
    };

    gamefunction::gamefunction()
    {
        this->isPlay = true;
        this->firstRun = true;
    }

} 
#endif