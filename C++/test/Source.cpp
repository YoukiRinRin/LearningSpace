#include "DxLib.h"

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hprevInstance, LPSTR lpCmdLine, int nCmdShow)
{
	ChangeWindowMode(TRUE);
	DxLib_Init();
	//DrawPixel(320, 240, GetColor(255, 255, 255));
	SetDrawScreen(DX_SCREEN_BACK);

	int Handle;
	int x = 50;
	int y = 100;
	Handle = LoadGraph("S:/Mario_dot/Mario1.jpg");
	DrawGraph(50, 100, Handle, TRUE);
	
	while (1) {
		if (CheckHitKey(KEY_INPUT_ESCAPE) == 1) {
			break;
		}
		ClearDrawScreen();
		DrawGraph(x, y, Handle, TRUE);
		x = x + 2;
		y = y + -2; 
		ScreenFlip();
	}

	DxLib_End();
	return 0;
}