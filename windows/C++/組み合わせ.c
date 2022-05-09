#include<stdio.h>
#include<stdbool.h>

#define N 16

int buffer[N];
bool used[N + 1];

void print_perm(int n){
    for(int i = 0; i< n; i++)
    printf("%d",buffer[i]);
    printf("\n");
    }

void perm_sub(int n, int m, int k){
    if(k == m)
     print_perm(m);
    else{
        for(int i = 1; i<= n; i++){
            if(used[i])continue;
            used[i] = true;
            perm_sub(n,m,k +1);
            used[i] = false;
        }
    }
}

void permutations(int n,int m){
    if(n > 0 && n < && m <= n && m <= n)permsub(n,m,0);
}



int combination(int n, int r)
{
    if(r == 0 || r == n ){
        return(1);
    }else if(r == 1){
        return(n);
        return(combination(n -1,r-1) + combination(n -1 , r));
    }
}

int main(void){
    int n, r;

    puts("異なるn個からrこの整数を取り出す組み合わせの数を求めます。");
    printf("n:");scanf("%d",)

    printf("r："); scanf("%d", &r);
    
    printf("組合せの数は%dです。\n", combination(n, r));

}


