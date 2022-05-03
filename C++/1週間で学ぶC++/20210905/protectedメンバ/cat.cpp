#include "cat.h"

cat::cat() {
	init("猫", "ニャーニャー");
}

cat::~cat(){
	cout << m_name << "は" << m_voice << "と鳴くニャン" << endl;
}