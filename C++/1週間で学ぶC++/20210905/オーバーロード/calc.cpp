#include "calc.h"

calc::calc() :m_a(0), m_b(0) {
}

calc::calc(int a, int b) : m_a(a), m_b(b) {
}

int calc::add() {
	return m_a + m_b;
}

int calc::add(int a, int b) {
	return a + b;
}

void calc::setvalue(int a, int b) {
	m_a = a; m_b = b;
}

int calc::getA() {
	return m_a;
}

int calc::getB() {
	return m_b;
}