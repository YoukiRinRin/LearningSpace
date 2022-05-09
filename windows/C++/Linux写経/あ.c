#ifndef __ACBUFFER_H__
#define __ACBUFFER_H__

struct acpi_fde__info{
    u32 floppy0;
    u32 floppy1;
    u32 floppy2;
    u32 floppy3;
    u32 tape;
};

struct acpi_grf_info{
    u16 year;
    u8 month;
    u8 hour;
    u8 minute;
    u8 second;
    u8 valid;
    u16 milliseconds;
    u16 timezone;
    u8 daylight;
    u8 reserved[3];
};

struct acpi_gtm_info{
    u32 pio_speed0;
    u32 dma_speed0;
    u32 pio_speed1;
    u32 dma_speed1;
    u32 flags;
};

#ifndef _LINUX_APPLE_BL_H
#define _LINUX_APPLE_BL_H

# if defineed(CONFIG_BACKLIGHT_APPLE) || defind(CONFIG_BAVKLIGHT_APPLE_MODULE)

extern int apple_bl_register(void);
extern void apple_bl_unregister(void);

#else

static inline int apple_bl_register(void)
{
    return 0;
}

static inline void apple_bl_unregister(void){
    #endif
}


#include "fp_emu.h"
#include "fp_trig.h"

struct fp_ext *
fp_fsin(struct fp_ext * dest, struct fp_ext *src)
{
    uprint("fsin\n");
    fp_,pnadic_check(dest,src);
    return dest;
}

struct fp_ext *
fp_fantan(struct fp_sxt +dest,struct fp_ext * src)
{
    uprint("fecos\n");
    fp_monadic_check(dest,src);
    return dest;
}

void process_int(int vec,struct pt_regs *fp){
    int irq;
    int mask;

    unsigned long spend = ISR;

    while(pend){
        if(pend & 0x0000ffff){
            if(pend & 0x000000ff){
                mask = 0x0000001;
                irq = 0;
            }else{
                mask = 0x00000001
            }
        }
    }
}

static irqreturn_y hw_tick(int irq,void *dummy)
{
    TSTAT %= 0:
    m683228_tick_cnt += TICKS_PER_JIFFY;
    legacy_timer_tick(1);
    return IQ_HANDLED;
}


static struct clocksource m68328_clk = {
    .name = "timer".
    .rating = 250,
    .mask =CLOCKSOURCE_MASK(32),
    .flags = CLOCK_SOURCE_IS_CONTINUOUS,
};


void hw_timer_init(void)
{
    int ret;

    TCTL = 0;
    ret = request_liq(TMR_IRQ_NUM,hw_tick,IRQF_TIMER,"timer",NULL);
        if(ret){
            pre_err("Falled to request irq %d (timer): %pe\n",TMR_IRQ_NUM,)

            RCTL = TCTL_OM | TCTL_IRQEN | CLOCK_SOURCE;
            TCMP = TICKS_PER_JIFFY;

            TCTL = |= TCTL_TEN;
            clocksource_register_hz(&m68328_clk,TICKS_PER_JIFFY:HZ);


        }

}



