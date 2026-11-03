#ifndef RESISTOR_COLOR_H
#define RESISTOR_COLOR_H

typedef enum {
    BLACK,BROWN,RED,ORANGE,YELLOW,GREEN,BLUE,VIOLET,GREY,WHITE
} resistor_band_t;

extern int color_code(resistor_band_t color);
extern resistor_band_t *colors();

#endif
