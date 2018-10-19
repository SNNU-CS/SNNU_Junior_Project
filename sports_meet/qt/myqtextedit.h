#ifndef MYQTEXTEDIT_H
#define MYQTEXTEDIT_H

#include<QLineEdit>
#include<QPlainTextEdit>

// 文本框类，继承自QPlainTextEdit，继承后添加了一个槽
class myQTextEdit : public QPlainTextEdit
{
    // QT宏，有信号和槽必须有这个宏
    Q_OBJECT
public:
    void setedit( QLineEdit *edit ); // 将自己私有成员变量和edit绑定(edit为输入框)
public slots:
    void mysetvalue(); // 槽，当点击按钮的时候，该槽接受，运算解答。
private:
    QLineEdit *edit;
};

#endif // MYQTEXTEDIT_H
