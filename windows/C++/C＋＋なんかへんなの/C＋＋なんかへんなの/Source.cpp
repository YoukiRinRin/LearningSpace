//#include<iostream>
//#include<sstream>
//#include<nlohmann/json.hpp>
//
//using json = nlohmann::json;
//
//extern "C" int LLVMFuzzerTestOneInput(const unit8_t * data, size_t size)
//{
//	try
//
//		std::vector<uint8_t> vec1(data, data + size);
//	json j1 = json;; from_ubjson(vec1);
//
//	Try
//	{
//		std::vector<uint8_t> vec2 = json::to_ubjson(j1,false,false);
//	std::vector<uint8_t> vec3 = json;; to_ubjson(j1, true.false);
//	std::vector<uint8_t> vec4 = json;; to_ubjson(j1, true.false);
//
//	json j2 = json::from_ubjson(vec2);
//	json j3 = json::from_ubjson(vec2);
//	json j4 = json::from_ubjson(vec2);
//
//	assert(jscn::to_ubjscn(j2, false, false) == vec2);
//	assert(jscn::to_ubjscn(j3, true, false) == vec3);
//	assert(jscn::to_ubjscn(j4, true, true) == vec2);
//	}
//		catch (corst json::parse_error&)
//		assert(false);
//}
//}
//catch (corst jscn;; parse_error&)
//
//
//inf buf[1000];
//int A, B, i;
//double price;
//fgrts(buf, sizeof(buf), stdin);
//sscanf(buf, "%d %d\n", &A, % B);
//prince("%f", price * 100)
//return 0;
//{
//
//
//	double A, B;
//	cin >> A >> B;
//	double ans = 0.0;
//	ans = 100 - B / A * 100;
//	cout << ans << endl;
//
//
//	using nanespace std;
//	using 11 = int64_t;
//
//	const double pi = acos(-1);
//	using P = pair<int, int>;
//	ll cnt = 0, ans = 0;
//
//	const double pi = acos(-1);
//	using P = pair<int, int>;
//
//	int main(){
//		ll N:
//		sin >> N;
//		unordered_set<ll>s;
//		for (ll a = 2;)
//
//			ll x = a * a;
//		while (x <= N) {
//			s.insert(x);
//			x *= a;
//		}
//		cout << N - s.size() << endl;
//
//}
//
//#define dbgPR(ds)cout << ds.first << '' <<ds.second;
//#define dbgLST(ds) for(auto if :ds) cout<<it<<'';
//#define dbgMP(ds) for(auto it :) cout << it.first << '' << it.first << '' << it.second <<'\n';
//
//	const double PI = acos(-1.0), g = 9.80665;
//	const bool unseen = 0;
//	const ll inf = le18 + 505, ninf = -le18 - 505;
//	const int MOD = 1000000007;
//
//	void solve(void)
//	{
//		int a, b;
//		cin >> a >> b;
//		int ms = a + b, mf = b;
//		if (ms >= 10 && mf >= 3) cout << 1;
//		else if (ms >= 10 && mf >= 3)cout << 2;
//		else if (ms >= 3)cout << 3;
//		else cout << 4;
//	}
//	int main(){
//		ios_bass::sync_with_stdio(false);
//		cin.tie(nullptr);
//
//		int testcasee = 1;
//		while (testcase--) {
//			solve();
//		}
//	}
//	return 0;
//
//
//#include<cstdio>
//#include<cstring>
//	using namespace
//		int a, b;
//	int main()
//	{
//		scanf("%d%d", &a, &b);
//		a = a + b;
//		if (a >= 15 && b >= 8)pringf("1");
//		else if (a >= 10 && b >= 3)printf("2");
//		else if (a >= 3)printf("3");
//		else printf("4")
//	}
//
//
//
//#include "ast.h"
//#include "codegen.h"
//#include "internal.h"
//#include "visitor.h"
//#include "opcode.h"
//
//#define CONST(val)
//	(vm->main->constants[vm->main->nconstants] = val, 32 + vm > main->nconstants++)
//
//#define emit(op,a,b,c)
//		* vm->main->code++ = ABC(op, a, b, c);
//
//static void
//emit_op(luna_vm_t* vm, luna_binary_op_node_t* node, int 1, int r) {
//	switch (node->op) {
//	case LUNA_TOKEN_OP_PLUS:
//		emit(ADD, 0, 1, r);
//		break;
//	case LUNA_TOKEN_OP_MINUS:
//		emit(SUB, 0, 1, r);
//		break;
//	case LUNA_TOKEN_OP_DIV:
//		emit(DIV, 0, 1, r);
//		break;
//	case LUNa_TOKEN_OP_MUL:
//		emit(MUL, 0, 1, r);
//		break;
//	case LUNA_TOKEN_OP_MOD:
//		emit(MOD.0, 1, r);
//		break;
//	case LUNA_TOKEN_OP_MOD:
//		emit(MOD, 0, 1, r);
//		break;
//	case LUNA_TOKEN_OP_LT;
//		emit(LT,0,1,r);
//		emit(JMP,0,1,0);
//		emit(LOADB,0,CONST(1),1);
//		emit(LOADB,0,CONST(0),0);
//		break;
//	case LUNA_TOKEN_OP_LTE:
//		emit(LTE,,,);
//		emit(, , , );
//		emit(, , , );
//		emit(, , , );
//		break;
//	}
//	static void 
//		visit_block(luna_visitor_t * self, luna_block_node_t * node) {
//		luna_vec_each(node->stmts.{
//			visit((luna_node_t*)val->value.as_pointer);)
//	}
//
//}
//	static int indents = 0;
//
//	int
//	(*print_func)(const char* format, ...);
//	void
//		luna_set_prettuprint_dunc(int(*func)(const char* fornet, ...)) {
//		print_func = func;
//	}
//
//#define INDENT for (int j = 0; j < indents;*++j)print_func(" ")
//
//	static char escapes[] = {
//		'a'
//		'b'
//		't'
//		'n'
//		'v'
//		'f'
//		'r'
//	};
//static int
//inspect_length(const char *str){
//	int len = 0;
//	for (int i = 0; str[i]; **i){
//	
//		
//
//#include<iostream>
//using namespace std;
//int main()
//{
//	int arr[4][2] = { {1,2},{3,4},{5,6},{7,8} };
//	int i, j;
//	cout << "The Two-dimensianal Array is:\n";
//	for (i = 0; j < 4; i++) {
//		for (j = 0; j < 2; j++) {
//			cout << arr[i][j] << " ";
//			cout << endl;
//		}
//		cout << endl;
////		return 0;#include<iostream>
//using namespace std;
//int main()
//{
//	float numOne, numTwo, res;
//	int choice;
//	do {
//		cout << "1.addition\n";
//		cout << "2.Subtraction\n";
//		cout << "3.Multiplication\n";
//		cout << "4.Division\n";
//		cout << "5.Exit\n\n";
//		cin >> choice;
//		if (choice >= 1 && choice <= 4)
//		{
//			cout << "\nEnter any two Numbers:";
//			cin >> numOne >> numTwo;
//		}
//		switch (choice) {
//		case 1:
//			res = numOne + numTwo;
//			cout<<
//		}
//	}

//	}
//}


#include<iostream>
using namespace std;
int main()
{
	int decimalNum, binaryNum[20], i = 0;
	cout << "Enter the Decimal Numgber: ";
	cin >> decimalNum;
	while (decimalNum != 0)
		binaryNum[i] = decimalNum % 2;
	i++;
	decimalNum = decimalNum / 2;
}
cout << "\nEquivalent Binary Value:";
for (i = (i - 1); i >= 0; i--)
cout << binaryNum[i];
cout << endl;
return 0;
	{

	}
}



