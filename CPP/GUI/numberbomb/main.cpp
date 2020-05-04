#include "maininterface.h"
#include "gamedata.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainInterface hall;
    gdata::gamedata gamesetting;
    hall.show();
    return a.exec();
}
