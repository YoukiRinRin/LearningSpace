// shoot.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include <iostream>
#include "DxLib.h"

int c = 0, White, i = 0;

void ShotType1(void);
void ShotType2(void);
void ShotType3(void);


void(*shorFunction[])(void) =
{
    ShotType2,
    ShotType1,
    ShotType3,
};

void ShotType1(void) {
    DrawString(200, 200, "タイプ1ショット発射中。", White);
}
void ShotType2(void) {
    DrawString(200, 200, "タイプ2ショット発射中", White);
}
void ShotType3(void) {
    DrawString(200, 200, "タイプ2ショット発射中", White);
}

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow) {

    ShangeWindowMode(TRUE);
    if (DxLib_Init() == -1)return -1;

    White GetColor(255, 255, 255);
    SetDrawScreen(DX_SCREEN_BACK);

    While(1) {
        ClearDrawScreen();
        if (c == 0)
            i = 0;
        else if (c == 100)
            i = 1;
        else if (c == 200)
            i = 2;
        else if (c == 300)
            break;
        ShotFunction[i]();
        c++:
        ScreenFlip();
    }
    DxLib_end();
    return 0;

}


int main()
{
    std::cout << "Hello World!\n";
}

// プログラムの実行: Ctrl + F5 または [デバッグ] > [デバッグなしで開始] メニュー
// プログラムのデバッグ: F5 または [デバッグ] > [デバッグの開始] メニュー

// 作業を開始するためのヒント: 
//    1. ソリューション エクスプローラー ウィンドウを使用してファイルを追加/管理します 
//   2. チーム エクスプローラー ウィンドウを使用してソース管理に接続します
//   3. 出力ウィンドウを使用して、ビルド出力とその他のメッセージを表示します
//   4. エラー一覧ウィンドウを使用してエラーを表示します
//   5. [プロジェクト] > [新しい項目の追加] と移動して新しいコード ファイルを作成するか、[プロジェクト] > [既存の項目の追加] と移動して既存のコード ファイルをプロジェクトに追加します
//   6. 後ほどこのプロジェクトを再び開く場合、[ファイル] > [開く] > [プロジェクト] と移動して .sln ファイルを選択します
