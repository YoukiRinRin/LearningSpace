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
//    char buf[YMAX][XMAX];                      // 文字配列(ﾌｨｰﾙﾄﾞ)
//    int  xM = 30, yM = 0;                           // ｷｬﾗｸﾀM 位置
//    int  dxM = 1;                                // ｷｬﾗｸﾀM 移動量(左右)
//    int  xMb, yMb = YMAX;                         // ｷｬﾗｸﾀM ﾋﾞｰﾑ$ 位置
//    int  xA = 40, yA = YMAX - 1;                      // ｷｬﾗｸﾀA 位置
//    int  xAb, yAb = -1;                           // ｷｬﾗｸﾀA ﾋﾞｰﾑ| 位置
//    int  i, j;                                  // 文字配列添字
//
//    while (1)
//    {
//        system("cls");                         // 画面消去
//
//        memset(&buf[0][0], ' ', XMAX * YMAX);      // 文字配列ｸﾘｱ
//        buf[yM][xM] = 'M';                       // M 配置
//        buf[yA][xA] = 'A';                       // A 配置
//        if (yMb < YMAX) buf[yMb][xMb] = '$';     // $ 配置
//        if (yAb >= 0) buf[yAb][xAb] = '|';     // | 配置
//
//        for (i = 0; i < YMAX; i++)
//        {
//            printf("%.*s", XMAX, &buf[i][0]);    // 画面1行表示
//        }
//        fflush(stdout);
//
//        if (xM == xAb && yM == yAb)              // M,| 当り
//        {
//            Beep(784, 1000); break;
//        }           // 終了
//
//        if (xA == xMb && yA == yMb)              // A,$ 当り
//        {
//            Beep(330, 1000); break;
//        }           // 終了
//
//        if (xAb == xMb && abs(yAb - yMb) <= 1)     // |,$ 当り
//        {
//            Beep(588, 100);
//            yAb = -1; yMb = YMAX;                 // ﾋﾞｰﾑ消滅
//        }
//
//        if (xM == 0 || xM == 79) dxM = -dxM;       // M 両端で反転
//        xM += dxM;                               // M 位置更新
//        if (yMb < YMAX) yMb += 1;                // $ 1行下へ
//        if (yAb >= 0) yAb -= 1;                // | 1行上へ
//
//        if (kbhit() != 0)                     // ｷｰが押された
//        {
//            j = getch();                        // ｷｰ番号
//            if (j == 27) break;                // Esc(終了)
//            if (j == 0) j = getch();           // 特殊ｷｰ
//            if (j == 75)                       // ←
//            {
//                xA -= 3;                         // M 3桁左へ
//                if (xA < 0) xA = 0;              // 左端
//            }
//            else if (j == 77)                  // →
//            {
//                xA += 3;                         // M 3桁右へ
//                if (xA >= XMAX) xA = XMAX - 1;     // 右端
//            }
//            if (j == 72 && yAb < 0)              // ↑,|なし
//            {
//                xAb = xA; yAb = yA - 1;
//            }            // | 発射
//        }
//
//        if (xA == xM && yMb >= YMAX)             // A,M x同位置,$なし
//        {
//            xMb = xM; yMb = 1;
//        }                   // $ 発射
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

	printf("\nあみだくじ(AA)\n");
	
	INIbuf();
	DISP();

	while (1) {
		printf("\n番号を入力してください(１～%d以外で終了):", LMAX);
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