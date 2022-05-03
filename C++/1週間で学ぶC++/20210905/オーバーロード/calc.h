#pragma once
#ifdef _CALC_H_
#define _CALC_H_
#endif // _CALC_H_

class calc {
private:
	int m_a, m_b;
public:
	calc();
	calc(int a, int b);
	int add();
	int add(int a, int b);

	void setvalue(int a, int b);
	int getA();
	int getB();
};


