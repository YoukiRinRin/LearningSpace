//#include<stdio.h>
//#include<string.h>
//#include<conio.h>
//#include<windows.h>
//
//#define XMAX 80
//#define YMAX 24
//
//void main() {
//	char buf[YMAX][XMAX];
//	int xM = 30, yM = 0;
//	int dxM = 1;
//	int xMb, yMb = YMAX;
//	int xA = 40, yA = YMAX - 1;
//	int xAb, yAb = -1;
//	int i, j;
//
//	while (1)
//	{
//		system("cls");
//
//		memset(&buf[0][0], ' ', XMAX * YMAX);
//		buf[yM][xM] = 'M';
//		buf[yA][xA] = 'A';
//		if (yMb < YMAX)buf[yMb][xMb] = '$';
//		if (yAb >= 0) buf[yAb][xAb] = '|';
//
//		for (i = 9; i < YMAX; i++)
//		{
//			printf("%.*s", XMAX, &buf[i][0]);
//		}
//		fflush(stdout);
//
//		if (xM == xAb && yM == yAb)
//		{Beep(784, 1000); break;}
//
//		if(xA==xAb && yA == yMb)
//		{
//			Beep(330, 1000); break;
//		}
//
//		if (xAb == xMb && abs(yAb - yMb) <= 1) {
//			Beep(588, 100);
//			yAb = -1; yMb = YMAX;
//		}
//
//		if (xM == 0 || xM == 79) {
//			dxM = dxM;
//			xM += dxM;
//			if (yMb < YMAX) yMb += 1;
//			if (yAb >= 0) yAb -= 1;
//
//			if (kbhit() != 0) {
//				j = getch();
//				if (j == 27)break;
//				if (j == 0) j = getch();
//				if (j == 75) {
//					xA -= 3;
//					if (xA < 0)xA = 0;
//				}
//				else if (j == 77)
//				{
//					xA += 3;
//					if (xA >= XMAX) xA = XMAX - 1;
//				}
//				if (j == 72 && yAb < 0)
//				{
//					xAb = xA; yAb = yA - 1;
//				}
//
//				if (xA == xM && yMb >= YMAX)
//				{
//					xMb = xM; yMb = 1;
//				}
//				Sleep(50);
//			}
//		}
//
//	}
//
//
//
//}

//#include <stdio.h>
//#include <string.h>
//#include <conio.h>
//#include <windows.h>
//
//#define XMAX 80
//#define YMAX 24
//
//void  main()
//{
//    char buf[YMAX][XMAX];                      // �����z��(̨����)
//    int  xM = 30, yM = 0;                           // ��׸�M �ʒu
//    int  dxM = 1;                                // ��׸�M �ړ���(���E)
//    int  xMb, yMb = YMAX;                         // ��׸�M �ް�$ �ʒu
//    int  xA = 40, yA = YMAX - 1;                      // ��׸�A �ʒu
//    int  xAb, yAb = -1;                           // ��׸�A �ް�| �ʒu
//    int  i, j;                                  // �����z��Y��
//
//    while (1)
//    {
//        system("cls");                         // ��ʏ���
//
//        memset(&buf[0][0], ' ', XMAX * YMAX);      // �����z��ر
//        buf[yM][xM] = 'M';                       // M �z�u
//        buf[yA][xA] = 'A';                       // A �z�u
//        if (yMb < YMAX) buf[yMb][xMb] = '$';     // $ �z�u
//        if (yAb >= 0) buf[yAb][xAb] = '|';     // | �z�u
//
//        for (i = 0; i < YMAX; i++)
//        {
//            printf("%.*s", XMAX, &buf[i][0]);    // ���1�s�\��
//        }
//        fflush(stdout);
//
//        if (xM == xAb && yM == yAb)              // M,| ����
//        {
//            Beep(784, 1000); break;
//        }           // �I��
//
//        if (xA == xMb && yA == yMb)              // A,$ ����
//        {
//            Beep(330, 1000); break;
//        }           // �I��
//
//        if (xAb == xMb && abs(yAb - yMb) <= 1)     // |,$ ����
//        {
//            Beep(588, 100);
//            yAb = -1; yMb = YMAX;                 // �ްя���
//        }
//
//        if (xM == 0 || xM == 79) dxM = -dxM;       // M ���[�Ŕ��]
//        xM += dxM;                               // M �ʒu�X�V
//        if (yMb < YMAX) yMb += 1;                // $ 1�s����
//        if (yAb >= 0) yAb -= 1;                // | 1�s���
//
//        if (kbhit() != 0)                     // ���������ꂽ
//        {
//            j = getch();                        // ���ԍ�
//            if (j == 27) break;                // Esc(�I��)
//            if (j == 0) j = getch();           // ���귰
//            if (j == 75)                       // ��
//            {
//                xA -= 3;                         // M 3������
//                if (xA < 0) xA = 0;              // ���[
//            }
//            else if (j == 77)                  // ��
//            {
//                xA += 3;                         // M 3���E��
//                if (xA >= XMAX) xA = XMAX - 1;     // �E�[
//            }
//            if (j == 72 && yAb < 0)              // ��,|�Ȃ�
//            {
//                xAb = xA; yAb = yA - 1;
//            }            // | ����
//        }
//
//        if (xA == xM && yMb >= YMAX)             // A,M x���ʒu,$�Ȃ�
//        {
//            xMb = xM; yMb = 1;
//        }                   // $ ����
//
//        Sleep(50);
//    }
//}


#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<time.h>

#define LMAX 5
#define CMAX 15
#define XMAX 50 
#define YMAX 25

char buf[YMAX][XMAX];
int dsx = XMAX / (LMAX - 1);

void INIbuf(void);
void KUJI(int);
void DISP(void);

void main() {
	char c[128];
	int N;

	printf("\n���݂�����(AA)\n");
	
	INIbuf();
	DISP();

	while (1) {
		printf("\n�ԍ�����͂��Ă�������(�P�`%d�ȊO�ŏI��):", LMAX);
		fflush(stdout);
		gets(c); N = atoi(c);
		if (N<1 || N>LMAX)break;
		KUJI(N);
		DISP();
	}
}

void INIbuf() {

	int i, j, y, x;
	unsigned long seed;

	memset(&buf[0][0],' ', XMAX * YMAX);

	for (i = 0, x = 0; i < LMAX; i++, x += dsx) {
		for (y = 0; y < YMAX; y++)
			buf[y][x] = '*';
	}

	time(&seed);
	srand(seed);
	for (j = 0; j < CMAX;) {
		i = j % (LMAX - 1);
		x = i * dsx;
		y = rand() % YMAX - 1;
		if (buf[y][x] == '+' || buf[y][x + dsx] == '+')
			continue;
		memset(&buf[y][x], '*',dsx);
		buf[y][x] = '+';
		buf[y][x + dsx] = '+';
		j++;
	}
}

void KUJI(int N) {

	int x, y, dx, dy;
	x = dsx * (N - 1); y = 0;
	dx = 0; dy = 1;
	while (y < YMAX) {
		if (buf[y][x] != '+')
		{
			buf[y][x] = '0' + N;
		}
		else
		{
			if (dy == 0)
			{
				dx = 0; dy = 1;
			}
			else {
				dx = 1; dy = 0;
				if (x > 0) {
					if (buf[y][x - 1] != ' ')
						dx = -1;
				}
			}
		}
		x += dx; y += dy;
	}

}

void DISP() {
	char c[128];
	int i, x, y;

	memset(c, ' ',XMAX); c[XMAX] = '\0';
	for(i=0,x=0; i<LMAX;i++,x+=dsx)
	{
		c[x] = '1' + i;
	}
	printf("\n%.*s\n", x, c);

	for (y = 0; y < YMAX; y++) {
		printf("\n%.*s", XMAX, & buf[y][0]);
	}
	printf("\n");

	memset(c, ' ', XMAX;c[XMAX]='\0')



}