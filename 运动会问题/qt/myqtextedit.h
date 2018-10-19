#ifndef MYQTEXTEDIT_H
#define MYQTEXTEDIT_H

#include<QLineEdit>
#include<QPlainTextEdit>
class myQTextEdit : public QPlainTextEdit
{
    Q_OBJECT
public:
    void setedit( QLineEdit *edit );
public slots:
    void mysetvalue();
private:
    QLineEdit *edit;
};

#endif // MYQTEXTEDIT_H
