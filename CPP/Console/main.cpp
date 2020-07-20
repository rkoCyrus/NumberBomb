#include "Gameflow.hpp"

using namespace numberbomb;

int main()
{
    /*Assuming this player wont play again first*/
    GameControl::playAgain = false;
    /*Create pregame flow when first run*/
    Pregame pg;
    /*A loop for controlling entire game flow*/
    do
    {
        pg.setUp(); /*Setting user preference*/

        if (GameControl::playAgain)
        {
            Pregame pg(GameControl::previousLuckNum); /*Renew object*/
        }
    }
    while(GameControl::playAgain);
}
