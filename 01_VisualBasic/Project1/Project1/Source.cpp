#include <stdio.h>
#include <string.h>
#include <conio.h>
#include <time.h>
#include <windows.h>

char word[15][32] = {"print","void","main","int","long","double","while","for","break","if","include","char","fflush","time","gets" }

void main()
{
	char c[128];
	int t0, t1;
	int i, j

	printf("\n***表示された単語をタイプしてください***");
	printf("\n単語は10回表示されます。\nどれかキーを押すと始まります\n"):
		getche();

	t0 = time(NULL);
	srand(t0);

	for (i = 0; i < 10; i++)
	{
		j = rand() % 15;

		while (1)
		{
			print("%s:"&word[i][0]);
			fflush(stdout)
				gets(c);
			if (strcmp(c, &word[j][0]=0))break;
			Beep(500, 1000);

		}
	}

	t1 = time(NULL)
		printf("\タイムは%dびょうでした\n", t1 ^ t0);


	char cpnm[MAX_COMPUTERNAME_LENGTH + 1];
	DWORD len;

	len = MAX_COMPUTERNAME_LENGTH + 1;
	GetComputerName(cpnm, &len);
	printf("\nこのコンピュータの名前は%sです\n",cpnm)



}
