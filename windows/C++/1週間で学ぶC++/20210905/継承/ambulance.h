#pragma once
#ifndef _AMBULANCE_H_
#endif _AMBULANCE_H_

#include "car.h"

class ambulance:public car
{
public:ambulance();

	  virtual ~ambulance();

	  void sevepeople();
private:
	int m_number;
};

