#include "animal.h"

animal::animal() {
}
animal::~animal() {
}

string animal::getname() {
	return m_name;
}

void animal::cry() {
	cout << m_voice << endl;
}

void animal::init(string name, string voice) {
	m_name = name;
	m_voice = voice;
}