#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    int N,i=0;
    cin>>N;
    int *A = new int[N];
    while(cin>>A[i++]); // add element in array
    while(cout<<A[--N]<<' ' && N); 
    delete[] A; 
    return 0;
}
