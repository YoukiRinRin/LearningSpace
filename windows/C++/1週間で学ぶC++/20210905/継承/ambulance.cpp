#include "ambulance.h"
#include <iostream>

using namespace std;

ambulance::ambulance() :m_number(119) {
	cout << "*** ambulance�̃N���X�̃C���X�^���X�̐���**" << endl;
}

ambulance::~ambulance() {
	cout << "*** ambulance�̃N���X�̃C���X�^���X�̍폜**" << endl;
}

void ambulance::sevepeople() {
	cout << "�~�}�~������" << endl
		<< "�Ăяo����" << m_number << "��" << endl;
}

