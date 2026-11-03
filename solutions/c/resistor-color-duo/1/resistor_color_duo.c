#include "resistor_color_duo.h"
#include <string.h>

int color_code(const resistor_band_t colors[]){
    return colors[0]*10+colors[1];
}