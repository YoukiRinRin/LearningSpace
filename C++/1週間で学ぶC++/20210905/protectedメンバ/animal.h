#pragma once
#ifdef _ANIMA_H_
#define _ANIMA_H_
#endif // _ANIMA_H_

#include <iostream>

using namespace std;
class animal
{
protected:
	string m_name;
	string m_voice;
public:
	animal();
	virtual ~animal();
	string getname();
	void cry();
protected:
	void init(string name, string voice);
};

