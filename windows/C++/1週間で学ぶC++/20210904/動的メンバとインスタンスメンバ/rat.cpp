#include "rat.h"
#include <iostream>

using namespace std;

int rat::s_count = 0;

rat::rat() :m_id(0) {
	s_count++;
	m_id = s_count;
}

rat::~rat() {
	cout << "ネズミ:" << m_id << "消去" << endl;

}

void rat::showNum(){
	cout << "現在のネズミの数は" << s_count << "匹です" << endl;
}

void rat::squeak() {
	cout << m_id << ":" << "チューチュー" << endl;
}