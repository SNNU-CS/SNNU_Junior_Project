#include "myqtextedit.h"
#include "calendar.hpp"
#include<Qstring>
void myQTextEdit::setedit( QLineEdit *edit )
{
    this->edit = edit;
};

void myQTextEdit::mysetvalue()
{
    calendar ans( edit->text().toInt()); // 计算答案
    // 设置文本框内容
    this->setPlainText(QString::fromStdString(ans.return_string()));
};

