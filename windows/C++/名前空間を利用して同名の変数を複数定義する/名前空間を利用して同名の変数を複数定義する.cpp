// 名前空間を利用して同名の変数を複数定義する.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include <iostream>

using namespace std;

namespace A {
    int power;
}

namespace B {
    int power;
}

void funcA();
void funcB();

int main()
{
    std::cout << "Hello World!\n";
    A::power = 20;
    B::power = 30;

    cout << "main:A::power=" << A::power << endl;
    cout << "main:B::power=" << B::power << endl;

    funcA();
    funcB();
    return 0;
   
}


void funcA() {
    using namespace A;
    cout << "funcA:A::power=" << power << endl;
    cout << "funcB:B::power=" << B::power << endl;

    power = 40;
}

void funcB(){
    using namespace B;
    cout << "funcA:A::power=" << A::power << endl;
    cout << "funcB:B::power=" << power << endl;

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
