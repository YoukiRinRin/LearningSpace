#include "rat.h"
#include <iostream>

using namespace std;

int rat::s_count = 0;

rat::rat() :m_id(0) {
	s_count++;
	m_id = s_count;
}

rat::~rat() {
	cout << "�l�Y�~:" << m_id << "����" << endl;

}

void rat::showNum(){
	cout << "���݂̃l�Y�~�̐���" << s_count << "�C�ł�" << endl;
}

void rat::squeak() {
	cout << m_id << ":" << "�`���[�`���[" << endl;
}