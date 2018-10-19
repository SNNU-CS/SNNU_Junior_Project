// 应用控件
#include<QApplication>
// 组件
#include<QWidget>
// 按钮
#include <QPushButton>
// 单行文本框
#include<QLineEdit>
// 流(cin、cout，非std)
#include<QTextStream>
//窗口布局，垂直变化
#include<QVBoxLayout>
//窗口布局，水平变化
#include<QHBoxLayout>
// 文本框
#include<QTextEdit>
//格子窗口
#include<QGridLayout>
//提示文字
#include<QLabel>
#include<QTextCodec>
#include "myqtextedit.h"

int main(int argc, char *argv[])
{

    // 建立应用
    QApplication app(argc, argv);
    // 建立组件
    QWidget w;
    // 设置组件名字
    w.setWindowTitle(QStringLiteral("算法作业"));
    // 运行显示组件
    w.show();
    // 设置输出文本框
    myQTextEdit block2;
    //设置输入文本框
    QLineEdit edit;
    block2.setedit(&edit); // 输出文本框绑定输入文本框
    block2.setFixedSize(500,300);// 设置输出文本框大小
    block2.setFocusPolicy(Qt::NoFocus);// 设置输出文本框禁止被选中
    block2.setReadOnly(true);//设置输出文本框只读
    block2.setPlainText(QStringLiteral("谢可毅,赵旗\n王文鑫，许渊，孙浩"));//输出名字
    // 设置输入文本框提示语句
    edit.setPlaceholderText(QStringLiteral("请输入人数： "));
    // 设置按钮
    QPushButton button(QStringLiteral("确定"));
    // layout 布局控制类，用于控制布局
    QGridLayout layout;
    // 水平缩放倍数
    layout.setRowStretch(0,1);
    // 竖直缩放倍数
    // 倍数用于控制窗体大小变化后，相对位置关系。
    layout.setColumnStretch(3,1);
    // 添加组件，因为这里绑定了，所以不需要指定父类
    // 绑定输出文本框在第一行第二列
    layout.addWidget(&block2,1,2);
    // 绑定输入文本框在第三行第二列
    layout.addWidget(&edit,3,2);
    // 绑定按钮在第三行第三列
    layout.addWidget(&button,3,3);
    // 信号和槽
    // 当按下确定按钮的时候，发送信号给block的mysetvalue槽
    QObject::connect(&button,SIGNAL(pressed()),&block2,SLOT(mysetvalue() ));
    // 输出布局
    w.setLayout(&layout);
    // 程序运行
    return app.exec();
}
