#include "grains.h"

uint64_t square(uint8_t index){
    uint64_t i=0,num=1;
    if(index<1||index>64)return 0;
    for(i=1;i<index;i++){
        num*=2;
    }
    return num;
}

uint64_t total(void){
    uint64_t total=0,i;
    for(i=1;i<=64;i++)
    {
        total+=square(i);
    }
    return total;
}