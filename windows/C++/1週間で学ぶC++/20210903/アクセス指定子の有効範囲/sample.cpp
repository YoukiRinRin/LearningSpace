#include "sample.h"
#include <iostream>

using namespace std;

void sample::func1() {
	cout << "func1" << endl;
	a = 1;
	b = 1;
	func2();
}

void sample::func2() {
	a = 2;
	b = 2;
	cout << "a=" << a << "," << "b=" << b << endl;
}


