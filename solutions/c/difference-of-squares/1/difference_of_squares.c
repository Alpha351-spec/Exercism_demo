#include "difference_of_squares.h"

unsigned int sum_of_squares(unsigned int number){
    unsigned int i=0,sum=0;
    for(i=0;i<=number;i++)
    {
        sum+=(i*i);
    }
    return sum;
}
unsigned int square_of_sum(unsigned int number){
    unsigned int i=0,sum=0;
    for(i=0;i<=number;i++)
    {
        sum+=i;
    }
    return sum*sum;
}
unsigned int difference_of_squares(unsigned int number){
    int sum_squ=0,squ_sum=0;
    sum_squ=sum_of_squares(number);
    squ_sum=square_of_sum(number);
    return squ_sum-sum_squ;
}
