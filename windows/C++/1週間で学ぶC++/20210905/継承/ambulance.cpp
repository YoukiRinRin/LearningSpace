#include "ambulance.h"
#include <iostream>

using namespace std;

ambulance::ambulance() :m_number(119) {
	cout << "*** ambulanceのクラスのインスタンスの生成**" << endl;
}

ambulance::~ambulance() {
	cout << "*** ambulanceのクラスのインスタンスの削除**" << endl;
}

void ambulance::sevepeople() {
	cout << "救急救命活動" << endl
		<< "呼び出しは" << m_number << "番" << endl;
}

