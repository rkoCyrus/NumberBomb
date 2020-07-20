#include "Consideration.hpp"
namespace numberbomb
{
    //Controller for the game
    class GameControl
    {
        public:
            //Decide to allow play again or not
            static bool playAgain;
            //Previous lucky number
            static int previousLuckNum;

    };
    //Setup before start the gameflow
    class Pregame
    {
        public:
            //Invoking game setup flow
            void setUp();
            //Constructor (first run)
            Pregame();
            //Constructor (following)
            Pregame(int);
            //Return range
            int* range(int);
        private:
            //User input which maximium number for setting maxium number
            const int gameMode[3] = {100, 250, 500};

            
    };
    //In a gameflow
    class Ingame : public Consideration
    {
        public:
            Ingame(int,int[]);
        private:
            int optRange[2];
    };
}