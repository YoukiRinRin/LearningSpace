#include "dog.h"

dog::dog() {
	init("犬", "ワンワン");
}
dog::~dog() {
	cout << m_name << "は" << m_voice << "と鳴くワン" << endl;
}
