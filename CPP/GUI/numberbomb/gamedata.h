#ifndef GAMEDATA_H
#define GAMEDATA_H

namespace gdata {

    class gamedata
    {
    public:
        //First run constructor
        gamedata();

        //Constructor for next turn
        gamedata(int preLuckNum);

        //Initalizing game event
        void gamesetup(int maxRange);

    private:
        //Check does user want to exit
        bool isQuit;

        //Previous lucky number
        int preLuck;

        //Generated lucky number
        int luck;

        //Set the maxium number
        int maxNum;

        //Generating random number
        int genRandNum();
    };

};

#endif // GAMEDATA_H
