#include "car.h"
#include<iostream>

using namespace std;

car::car() :m_speed(0.0), m_migration(0.0) {
	cout << " car�N���X�̃C���X�^���X����" << endl;
}
car::~car() {
	cout << "car�N���X�̃C���X�^���X����" << endl;
}
void car::setspeed(double speed) {
	m_speed = speed;
}

double car::getspeed() {
	return m_speed;
}

double car::getMigration() {
	return m_migration;
}

void car::drive(double hour) {
	cout << "����" << m_speed << "km��" << hour << "���ԑ��s" << endl;
	cout << m_speed * hour << "km�ړ����܂���" << endl;
	m_migration += m_speed * hour;
}
