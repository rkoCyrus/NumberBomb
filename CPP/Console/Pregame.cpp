#include "Gameflow.hpp"
#include <iostream>
#include <random>

using namespace std;
using namespace numberbomb;

void Pregame::setUp() {
    int setGamemode;
    GameControl GC;
    cout << "Please select gamemode:\n1:1-100\n2:1-250\n3:1-500" << endl;
    while (true)
    {
        cout << "Enter: ";
        cin >> setGamemode;
        cout << "\n";
        if (!cin.fail() && setGamemode >=1 && setGamemode <= 3)
        {
            GC.luckNumResult = luckNum(gameMode[setGamemode - 1]);
            break;
        }
        else
        {
            cout << "Please enter valid number!" << endl;
        }
    }

}

int Pregame::luckNum(int MAX_RANGE)
{
    random_device randev;
    mt19937 rng(randev());
    uniform_int_distribution<mt19937::result_type> dist6(2,(MAX_RANGE - 1));
    return dist6(rng);
}