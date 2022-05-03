#include "car.h"
#include<iostream>

using namespace std;

car::car() :m_speed(0.0), m_migration(0.0) {
	cout << " carクラスのインスタンス生成" << endl;
}
car::~car() {
	cout << "carクラスのインスタンス消去" << endl;
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
	cout << "時速" << m_speed << "kmで" << hour << "時間走行" << endl;
	cout << m_speed * hour << "km移動しました" << endl;
	m_migration += m_speed * hour;
}
