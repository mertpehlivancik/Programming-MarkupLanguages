#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
//Complete the following function.

void calculate_the_maximum(int n, int k) {
  //Write your code here.
  int MaxAnd = 0;
  int MaxOr = 0;
  int MaxXor = 0;
  for(int i=1;i<=n;i++){
      for(int j=i+1;j<=n;j++){
          if((i&j)>MaxAnd && (i&j)<k){
              MaxAnd = i&j;
          }if((i|j)>MaxOr && (i|j)<k){
              MaxOr = i|j;
          }if((i^j)>MaxXor && (i^j)<k){
              MaxXor = i^j;
          }
      }
  }
  printf("%d\n",MaxAnd);
  printf("%d\n",MaxOr);
  printf("%d\n",MaxXor);
}

int main() {
    int n, k;
  
    scanf("%d %d", &n, &k);
    calculate_the_maximum(n, k);
 
    return 0;
}
