#include <iostream>
#include "sample.h"

using namespace std;

int sample::s_b = 0;

void sample::func1() {
    cout << "=== func1 ===" << endl;

    m_a = 1;

    s_b = 2;
    cout << "a=" << m_a << endl;
    cout << "b=" << s_b << endl;
}

void sample::func2() {
    cout << "===func2===" << endl;
    s_b = 4;
    cout << "b=" << s_b << endl;
}