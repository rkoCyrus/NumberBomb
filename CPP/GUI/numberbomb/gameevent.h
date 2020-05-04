#ifndef GAMEEVENT_H
#define GAMEEVENT_H

#include <QMainWindow>

namespace Ui {
class gameevent;
}

class gameevent : public QMainWindow
{
    Q_OBJECT

public:
    explicit gameevent(QWidget *parent = nullptr);
    ~gameevent();

private:
    Ui::gameevent *ui;
};

#endif // GAMEEVENT_H
