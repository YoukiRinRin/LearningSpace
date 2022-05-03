#pragma once
#ifndef _RAT_H_
#define _RAT_H_

class rat
{
public:
	rat();
	~rat();
	static void showNum();
	void squeak();
private:
	int m_id;
	static int s_count;
};
#endif

