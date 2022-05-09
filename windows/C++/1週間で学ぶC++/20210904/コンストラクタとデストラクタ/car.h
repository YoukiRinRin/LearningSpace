#pragma once
#ifndef _CAR_H_
#define _CAR_H_

class car
{
public: 
	car();
	~car();
	void setspeed(double speed);
	double getspeed();
	double getMigration();
	void drive(double hour);

private:
	double m_speed;
	double m_migration;
};
#endif
