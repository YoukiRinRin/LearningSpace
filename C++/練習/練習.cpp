// 練習.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include <iostream>
#include<conio.h>
#include<fstream>
#include<intrin.h>
int main()
{
    std::cout << "Hello World!\n";
    char buf[256];
    size_t read;

    printf("文字を入力してください");
    _cgets_s(buf, sizeof(buf), &read);
    printf("入力されたバイト数:%dバイト\n", read);



#ifdef __STDC__
    std::cout << "このコンパイラはANSI Cに基準しています。" << std::endl;
#else
    std::cout << "このコンパイラはANSI Cに基準していません。" << std::endl;
#endif

    unsigned __int64 i;
    i = __rdtsc();
    printf_s("%I64d \n", i);


    long a = 1;
    long b = 0;

    __asm
    {
        mov eax,a
        mov b.eax
    }
    printf("%d\n", b);
    return 0;



    return 0;
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
