#include<QApplication>
#include<QWidget>
#include<QPushButton>
#include<QLineEdit>
#include<QTextStream>
//窗口布局，垂直变化
#include<QVBoxLayout>
//窗口布局，水平变化
#include<QHBoxLayout>
#include<QTextEdit>
//格子窗口
#include<QGridLayout>
//提示文字
#include<QLabel>
#include "myqtextedit.h"

int main(int argc, char *argv[])
{
    QApplication app(argc, argv);

    QWidget w;
    w.setWindowTitle("算法作业");

    w.show();
    myQTextEdit block2;
    QLineEdit edit;
    block2.setedit(&edit);
    block2.setFixedSize(500,300);
    block2.setFocusPolicy(Qt::NoFocus);
    block2.setReadOnly(true);
    block2.setPlainText(QString("谢可毅\\n赵旗\n...."));
    //block2.setAlignment(Qt::AlignLeft | Qt::AlignTop);
    edit.setPlaceholderText("请输入人数： ");
    QPushButton button("确定");
    QGridLayout layout;
    layout.setRowStretch(0,1);
    layout.setColumnStretch(3,1);
    layout.addWidget(&block2,1,2);
    layout.addWidget(&edit,3,2);
    layout.addWidget(&button,3,3);
    QObject::connect(&button,SIGNAL(pressed()),&block2,SLOT(mysetvalue() ));

    //Layout是可以嵌套的
    //整个系统窗口中添加layout
    w.setLayout(&layout);
    app.exec();
}
