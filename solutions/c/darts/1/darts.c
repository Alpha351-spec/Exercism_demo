#include "darts.h"
#include <stdint.h>

int score(coordinate_t landing_position){
    double distance_squared=landing_position.row*landing_position.row+landing_position.cloumn*landing_position.cloumn;
    if(distance_squared<=1.0){
        return 10;
    }else if(distance_squared<=25.0){
        return 5;
    }else if(distance_squared<=100.0){
        return 1;
    }else{
        return 0;
    }
}
