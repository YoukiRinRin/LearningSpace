#pragma once
#ifdef _CAR_H
#define _CAR_H
#endif // _CAR_H

class car
{
public:
	car();
	
	virtual ~car();
	void setspeed(double speed);
	double getspeed(); 
	double getmigration();
	void drive(double hour);
private:
	double m_speed;
	double m_migration;
};

