#ifndef INGAME_H
#define INGAME_H
namespace NumberBomb
{
    //Rules when playing games
    class Ingame
    {
        private:
            //Range for guesting number
            int minRange, maxRange;
        public:
            //Initial all game event
            explicit Ingame();
            //Initial all game event from previous round
            explicit Ingame(int);
    };

    explicit Ingame::Ingame()
    {
        
    }

    explicit Ingame::Ingame(int preLuckNum)
    {

    }
}
#endif