#include "gameevent.h"
#include "ui_gameevent.h"

gameevent::gameevent(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::gameevent)
{
    ui->setupUi(this);
}

gameevent::~gameevent()
{
    delete ui;
}
