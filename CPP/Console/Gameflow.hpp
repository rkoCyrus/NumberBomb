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
            //Store current lucky number
            static int luckNumResult;

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
            //Invoke Ingame when terminating
            ~Pregame();
        private:
            //User input which maximium number for setting maxium number
            const int gameMode[3] = {100, 250, 500};
            //Generate lucky number
            int luckNum(int);
    };
    //In a gameflow
    class Ingame : private Consideration
    {
        using Consideration::Consideration;
        public:
            explicit Ingame(int);
            void gameInvoke();
        protected:
            int optRange[2];
        private:
            //Return range
            int* range(int);
    };

    //Code for constructor

    Pregame::Pregame()
    {
        GameControl::previousLuckNum = 0;
        setUp();
    }

    Pregame::Pregame(int previous)
    {
        GameControl::previousLuckNum = previous;
        setUp();
    }

    Pregame::~Pregame()
    {
        Ingame IG(GameControl::luckNumResult);
        IG.gameInvoke();
    }
}