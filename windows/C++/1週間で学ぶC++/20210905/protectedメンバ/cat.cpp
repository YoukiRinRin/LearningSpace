#include "cat.h"

cat::cat() {
	init("�L", "�j���[�j���[");
}

cat::~cat(){
	cout << m_name << "��" << m_voice << "�Ɩ��j����" << endl;
}