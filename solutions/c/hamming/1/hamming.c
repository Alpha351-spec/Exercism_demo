#include "hamming.h"
#include <string.h>

int compute(const char *lhs, const char *rhs){
    int count=0;
    if(strlen(lhs)==strlen(rhs)){
        for(long unsigned int i=0;i<strlen(lhs);i++){
            if(*(lhs+i)!=*(rhs+i)){
                count++;
            }
        }
        return count;
    }else{
        return -1;
    }
}