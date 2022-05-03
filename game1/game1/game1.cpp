// game1.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include <iostream>
#include "DxLib.h"


int WINAPI WinMain(HINSRANCE, HINSTANCE, LPSTR, int){
    ChangeWIndowMode(TRUE), DxLib_Init(), SetDrawScreen(DX_SCREEN_BACK);

    int x = 0;
    int Handle00,Handle01:
    Handle00 = LoadGraph("画像/キャラクタ00.png"):
        Handle00 = LoadGraph("画像/キャラクタ00.png"):

        While(ScreenFilp() == 0 && ProcessMessage() == 0 && ClearDrawScreen() {
        DrawGraph(x / 2, 0, Handle01, TRUE);
        DrawGraph(x / 2, 0, Handle00, TRUE);
        x++;
    }
    DxLib_End();
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
