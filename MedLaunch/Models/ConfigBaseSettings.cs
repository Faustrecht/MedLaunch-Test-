﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedLaunch.Classes;
using System.Windows.Controls;
using System.Windows;
using Microsoft.Data.Entity;
using System.Reflection;
using MahApps.Metro.Controls;
using Xceed.Wpf.Toolkit;
using System.Windows.Media;

namespace MedLaunch.Models
{
    public class ConfigBaseSettings
    {
        public int ConfigId { get; set; }
        public DateTime UpdatedTime { get; set; }
        public bool? isEnabled { get; set; }
        public int? systemIdent { get; set; }

        public bool? autosave { get; set; }                       // autosave
        public bool? cd__image_memcache { get; set; }             // cd.image_memcache
        public bool? cheats { get; set; }                         // cheats
        public bool? debugger__autostepmode { get; set; }         // debugger.autostepmode
        public bool? ffnosound { get; set; }                      // ffnosound
        public double? ffspeed { get; set; }                            // ffspeed                          (1 through 15)
        public bool? fftoggle { get; set; }                       // fftoggle
        public string filesys__path_cheat { get; set; }             // filesys.path_cheat
        public string filesys__path_firmware { get; set; }          // filesys.path_firmware
        public string filesys__path_movie { get; set; }             // filesys.path_movie
        public string filesys__path_palette { get; set; }           // filesys.path_palette
        public string filesys__path_pgconfig { get; set; }          // filesys.path_pgconfig
        public string filesys__path_sav { get; set; }               // filesys.path_sav
        public string filesys__path_savbackup { get; set; }         // filesys.path_savbackup
        public string filesys__path_snap { get; set; }              // filesys.path_snap
        public string filesys__path_state { get; set; }             // filesys.path_state
        public int? filesys__state_comp_level { get; set; }          // filesys.state_comp_level         (-1 through 9)
        public bool? filesys__untrusted_fip_check { get; set; }   // filesys.untrusted_fip_check
        public int? input__autofirefreq { get; set; }                // input.autofirefreq               (0 through 1000)
        public int? input__ckdelay { get; set; }                     // 0 through 99999
        public double? input__joystick__axis_threshold { get; set; }    // 0 through 100
        public bool? input__joystick__global_focus { get; set; }
        public bool? nothrottle { get; set; }
        public bool? osd__alpha_blend { get; set; }
        public int? osd__message_display_time { get; set; }          // 0 through 15000
        public int? osd__state_display_time { get; set; }            // 0 through 15000

        // new FPS options
        public bool? fps__autoenable { get; set; }
        public string fps__bgcolor { get; set; }                        // 0x00000000 through 0xFFFFFFFF           
        public string fps__font { get; set; }                          //  5x7 6x9 6x12 6x13 9x18
        public string fps__position { get; set; }                   // upper_left  upper_right
        public int? fps__scale { get; set; }                        // 0 through 32
        public string fps__textcolor { get; set; }                  // 0x00000000 through 0xFFFFFFFF

        public int? qtrecord__h_double_threshold { get; set; }       // 0 through 1073741824
        public string qtrecord__vcodec { get; set; }                // raw cscd png
        public int? qtrecord__w_double_threshold { get; set; }       // 0 through 1073741824
        public double? sfspeed { get; set; }                        // 0.25 through 1
        public bool? sftoggle { get; set; }
        public bool? sound { get; set; }
        public int? sound__buffer_time { get; set; }                 // 0 through 1000
        public string sound__device { get; set; }                   // default
        public string sound__driver { get; set; }                   // default alsa oss wasapish dsound wasapi sdl jack
        public int? sound__period_time { get; set; }                 // 0 through 100000
        public int? sound__rate { get; set; }                        // 22050 through 192000
        public int? sound__volume { get; set; }                      // 0 through 150
        public int? srwframes { get; set; }                          // 10 through 99999
        public bool? video__blit_timesync { get; set; }
        public string video__deinterlacer { get; set; }             // weave bob bob_offset
        public bool? video__disable_composition { get; set; }
        public string video__driver { get; set; }                    // default opengl, softfb (old: opengl sdl overlay)
        public bool? video__frameskip { get; set; }
        public bool? video__fs { get; set; }
        public bool? video__glvsync { get; set; }
        public int? video__fs__display { get; set; }              // -1 through 32767

        // generic system specific settings -   <system>.setting
        public bool? __enable { get; set; }
        public bool? __forcemono { get; set; }                      // force mono output
        public string __shader { get; set; }
        public int? __scanlines { get; set; }                       // -100 through 100
        public string __special { get; set; }
        public string __stretch { get; set; }
        public bool? __tblur { get; set; }
        public bool? __tblur__accum { get; set; }
        public double? __tblur__accum__amount { get; set; }         // 0 through 100
        public string __videoip { get; set; }
        public int? __xres { get; set; }                            // 0 through 65536
        public double? __xscale { get; set; }                       // 0.01 through 256
        public double? __xscalefs { get; set; }                     // 0.01 through 256
        public int? __yres { get; set; }                            // 0 through 65536
        public double? __yscale { get; set; }                       // 0.01 through 256
        public double? __yscalefs { get; set; }                     // 0.01 through 256

        

        // system specific settings

        // Atari Lynx
        public bool? lynx__lowpass { get; set; }
        public bool? lynx__rotateinput { get; set; }

        public bool? lynx__enable { get; set; }
        public bool? lynx__forcemono { get; set; }
        public string lynx__shader { get; set; }
        public int? lynx__scanlines { get; set; }
        public string lynx__special { get; set; }
        public string lynx__stretch { get; set; }
        public bool? lynx__tblur { get; set; }
        public bool? lynx__tblur__accum { get; set; }
        public double? lynx__tblur__accum__amount { get; set; }
        public string lynx__videoip { get; set; }
        public int? lynx__xres { get; set; }                            // 0 through 65536
        public double? lynx__xscale { get; set; }                       // 0.01 through 256
        public double? lynx__xscalefs { get; set; }                     // 0.01 through 256
        public int? lynx__yres { get; set; }                            // 0 through 65536
        public double? lynx__yscale { get; set; }                       // 0.01 through 256
        public double? lynx__yscalefs { get; set; }                     // 0.01 through 256

        public bool? lynx__shader__goat__fprog { get; set; }
        public double? lynx__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string lynx__shader__goat__pat { get; set; }
        public bool? lynx__shader__goat__slen { get; set; }
        public double? lynx__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? lynx__shader__goat__vdiv { get; set; }           // -2.00 through 2.00


        // Gameboy
        public string gb__system_type { get; set; }                 // auto dmg cgb agb

        public bool? gb__enable { get; set; }
        public bool? gb__forcemono { get; set; }
        public string gb__shader { get; set; }
        public int? gb__scanlines { get; set; }
        public string gb__special { get; set; }
        public string gb__stretch { get; set; }
        public bool? gb__tblur { get; set; }
        public bool? gb__tblur__accum { get; set; }
        public double? gb__tblur__accum__amount { get; set; }
        public string gb__videoip { get; set; }
        public int? gb__xres { get; set; }                            // 0 through 65536
        public double? gb__xscale { get; set; }                       // 0.01 through 256
        public double? gb__xscalefs { get; set; }                     // 0.01 through 256
        public int? gb__yres { get; set; }                            // 0 through 65536
        public double? gb__yscale { get; set; }                       // 0.01 through 256
        public double? gb__yscalefs { get; set; }                     // 0.01 through 256

        public bool? gb__shader__goat__fprog { get; set; }
        public double? gb__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string gb__shader__goat__pat { get; set; }
        public bool? gb__shader__goat__slen { get; set; }
        public double? gb__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? gb__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        // Gameboy Advance
        public string gba__bios { get; set; }

        public bool? gba__enable { get; set; }
        public bool? gba__forcemono { get; set; }
        public string gba__shader { get; set; }
        public int? gba__scanlines { get; set; }
        public string gba__special { get; set; }
        public string gba__stretch { get; set; }
        public bool? gba__tblur { get; set; }
        public bool? gba__tblur__accum { get; set; }
        public double? gba__tblur__accum__amount { get; set; }
        public string gba__videoip { get; set; }
        public int? gba__xres { get; set; }                            // 0 through 65536
        public double? gba__xscale { get; set; }                       // 0.01 through 256
        public double? gba__xscalefs { get; set; }                     // 0.01 through 256
        public int? gba__yres { get; set; }                            // 0 through 65536
        public double? gba__yscale { get; set; }                       // 0.01 through 256
        public double? gba__yscalefs { get; set; }                     // 0.01 through 256

        public bool? gba__shader__goat__fprog { get; set; }
        public double? gba__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string gba__shader__goat__pat { get; set; }
        public bool? gba__shader__goat__slen { get; set; }
        public double? gba__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? gba__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        // NeoGeo Pocket Color
        public string npg__language { get; set; }                   // english japanese

        public bool? ngp__enable { get; set; }
        public bool? ngp__forcemono { get; set; }
        public string ngp__shader { get; set; }
        public int? ngp__scanlines { get; set; }
        public string ngp__special { get; set; }
        public string ngp__stretch { get; set; }
        public bool? ngp__tblur { get; set; }
        public bool? ngp__tblur__accum { get; set; }
        public double? ngp__tblur__accum__amount { get; set; }
        public string ngp__videoip { get; set; }
        public int? ngp__xres { get; set; }                            // 0 through 65536
        public double? ngp__xscale { get; set; }                       // 0.01 through 256
        public double? ngp__xscalefs { get; set; }                     // 0.01 through 256
        public int? ngp__yres { get; set; }                            // 0 through 65536
        public double? ngp__yscale { get; set; }                       // 0.01 through 256
        public double? ngp__yscalefs { get; set; }                     // 0.01 through 256

        public bool? ngp__shader__goat__fprog { get; set; }
        public double? ngp__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string ngp__shader__goat__pat { get; set; }
        public bool? ngp__shader__goat__slen { get; set; }
        public double? ngp__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? ngp__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        // NES
        public bool? nes__clipsides { get; set; }
        public bool? nes__correct_aspect { get; set; }
        public bool? nes__fnscan { get; set; }
        public bool? nes__gg { get; set; }
        public string nes__ggrom { get; set; }
        public string nes__input__fcexp { get; set; }
        public string nes__input__port1 { get; set; }
        public string nes__input__port2 { get; set; }
        public string nes__input__port3 { get; set; }
        public string nes__input__port4 { get; set; }
        public bool? nes__n106bs { get; set; }
        public bool? nes__no8lim { get; set; }
        public bool? nes__nofs { get; set; }
        public double? nes__ntsc__brightness { get; set; }          // -1 through 1
        public double? nes__ntsc__contrast { get; set; }            // -1 through 1
        public double? nes__ntsc__hue { get; set; }                 // -1 through 1
        public bool? nes__ntsc__matrix { get; set; }
        public double? nes__ntsc__matrix__0 { get; set; }           // -2 through 2
        public double? nes__ntsc__matrix__1 { get; set; }           // -2 through 2
        public double? nes__ntsc__matrix__2 { get; set; }           // -2 through 2
        public double? nes__ntsc__matrix__3 { get; set; }           // -2 through 2
        public double? nes__ntsc__matrix__4 { get; set; }           // -2 through 2
        public double? nes__ntsc__matrix__5 { get; set; }           // -2 through 2
        public bool? nes__ntsc__mergefields { get; set; }
        public string nes__ntsc__preset { get; set; }               // disabled composite svideo rgb monochrome
        public double? nes__ntsc__saturation { get; set; }          // -1 through 1
        public double? nes__ntsc__sharpness { get; set; }          // -1 through 1
        public bool? nes__ntscblitter { get; set; }
        public bool? nes__pal { get; set; }
        public int? nes__slend { get; set; }                        // 0 through 239
        public int? nes__slendp { get; set; }                        // 0 through 239
        public int? nes__slstart { get; set; }                        // 0 through 239
        public int? nes__slstartp { get; set; }                        // 0 through 239
        public double? nes__sound_rate_error { get; set; }               // 0.0000001 through 0.01
        public int? nes__soundq { get; set; }                       // -2 through 3
        public string nes__debugger__disfontsize { get; set; }
        public string nes__debugger__memcharenc { get; set; }

        public bool? nes__enable { get; set; }
        public string nes__shader { get; set; }
        public int? nes__scanlines { get; set; }
        public string nes__special { get; set; }
        public string nes__stretch { get; set; }
        public bool? nes__tblur { get; set; }
        public bool? nes__tblur__accum { get; set; }
        public double? nes__tblur__accum__amount { get; set; }
        public string nes__videoip { get; set; }
        public int? nes__xres { get; set; }                            // 0 through 65536
        public double? nes__xscale { get; set; }                       // 0.01 through 256
        public double? nes__xscalefs { get; set; }                     // 0.01 through 256
        public int? nes__yres { get; set; }                            // 0 through 65536
        public double? nes__yscale { get; set; }                       // 0.01 through 256
        public double? nes__yscalefs { get; set; }                     // 0.01 through 256

        public bool? nes__shader__goat__fprog { get; set; }
        public double? nes__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string nes__shader__goat__pat { get; set; }
        public bool? nes__shader__goat__slen { get; set; }
        public double? nes__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? nes__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        // PC-Engine (Fast)
        public bool? pce_fast__adpcmlp { get; set; }
        public int? pce_fast__adpcmvolume { get; set; }             // 0 through 200
        public bool? pce_fast__arcadecard { get; set; }
        public string pce_fast__cdbios { get; set; }
        public int? pce_fast__cddavolume { get; set; }               // 0 thorugh 200
        public int? pce_fast__cdpsgvolume { get; set; }               // 0 thorugh 200
        public int? pce_fast__cdspeed { get; set; }                 // 1 through 100
        public bool? pce_fast__correct_aspect { get; set; }
        public bool? pce_fast__disable_softreset { get; set; }
        public bool pce_fast__forcesgx { get; set; }
        public string pce_fast__input__port1 { get; set; }
        public string pce_fast__input__port2 { get; set; }
        public string pce_fast__input__port3 { get; set; }
        public string pce_fast__input__port4 { get; set; }
        public string pce_fast__input__port5 { get; set; }
        public double? pce_fast__mouse_sensitivity { get; set; }    // 0.125 through 2
        public bool? pce_fast__nospritelimit { get; set; }
        public int? pce_fast__ocmultiplier { get; set; }            // 1 through 100
        public int? pce_fast__slend { get; set; }                   // 0 through 239
        public int? pce_fast__slstart { get; set; }                 // 0 through 239

        public bool? pce_fast__enable { get; set; }
        public bool? pce_fast__forcemono { get; set; }
        public string pce_fast__shader { get; set; }
        public int? pce_fast__scanlines { get; set; }
        public string pce_fast__special { get; set; }
        public string pce_fast__stretch { get; set; }
        public bool? pce_fast__tblur { get; set; }
        public bool? pce_fast__tblur__accum { get; set; }
        public double? pce_fast__tblur__accum__amount { get; set; }
        public string pce_fast__videoip { get; set; }
        public int? pce_fast__xres { get; set; }                            // 0 through 65536
        public double? pce_fast__xscale { get; set; }                       // 0.01 through 256
        public double? pce_fast__xscalefs { get; set; }                     // 0.01 through 256
        public int? pce_fast__yres { get; set; }                            // 0 through 65536
        public double? pce_fast__yscale { get; set; }                       // 0.01 through 256
        public double? pce_fast__yscalefs { get; set; }                     // 0.01 through 256

        public bool? pce_fast__shader__goat__fprog { get; set; }
        public double? pce_fast__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string pce_fast__shader__goat__pat { get; set; }
        public bool? pce_fast__shader__goat__slen { get; set; }
        public double? pce_fast__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? pce_fast__shader__goat__vdiv { get; set; }           // -2.00 through 2.00


        // PC-Engine
        public bool? pce__adpcmextraprec { get; set; }
        public int? pce__adpcmvolume { get; set; }                  // 0 through 200
        public bool? pce__arcadecard { get; set; }
        public string pce__cdbios { get; set; }
        public int? pce__cddavolume { get; set; }               // 0 thorugh 200
        public int? pce__cdpsgvolume { get; set; }              // 0 thorugh 200
        public bool? pce__disable_bram_cd { get; set; }
        public bool? pce__disable_bram_hucard { get; set; }
        public bool? pce__disable_softreset { get; set; }
        public bool? pce__forcesgx { get; set; }
        public string pce__gecdbios { get; set; }
        public bool? pce__h_overscan { get; set; }
        public bool? pce__input__multitap { get; set; }
        public string pce__input__port1 { get; set; }
        public string pce__input__port2 { get; set; }
        public string pce__input__port3 { get; set; }
        public string pce__input__port4 { get; set; }
        public string pce__input__port5 { get; set; }
        public double? pce__mouse_sensitivity { get; set; }         // 0.125 through 2
        public bool? pce__nospritelimit { get; set; }
        public string pce__psgrevision { get; set; }
        public int? pce__resamp_quality { get; set; }               // 0 through 5
        public double? pce__resamp_rate_error { get; set; }         //          0.0000001 throgh        0.0000350
        public int? pce__slend { get; set; }                        // 0 through 239
        public int? pce__slstart { get; set; }                      // 0 through 239
        public string pce__debugger__disfontsize { get; set; }
        public string pce__debugger__memcharenc { get; set; }

        public bool? pce__enable { get; set; }
        public bool? pce__forcemono { get; set; }
        public string pce__shader { get; set; }
        public int? pce__scanlines { get; set; }
        public string pce__special { get; set; }
        public string pce__stretch { get; set; }
        public bool? pce__tblur { get; set; }
        public bool? pce__tblur__accum { get; set; }
        public double? pce__tblur__accum__amount { get; set; }
        public string pce__videoip { get; set; }
        public int? pce__xres { get; set; }                            // 0 through 65536
        public double? pce__xscale { get; set; }                       // 0.01 through 256
        public double? pce__xscalefs { get; set; }                     // 0.01 through 256
        public int? pce__yres { get; set; }                            // 0 through 65536
        public double? pce__yscale { get; set; }                       // 0.01 through 256
        public double? pce__yscalefs { get; set; }                     // 0.01 through 256

        public bool? pce__shader__goat__fprog { get; set; }
        public double? pce__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string pce__shader__goat__pat { get; set; }
        public bool? pce__shader__goat__slen { get; set; }
        public double? pce__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? pce__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        // PC-FX
        public bool? pcfx__adpcm__emulate_buggy_codec { get; set; }
        public bool? pcfx__adpcm__suppress_channel_reset_clicks { get; set; }
        public string pcfx__bios { get; set; }
        public int? pcfx__cdspeed { get; set; }                     // 2 through 10
        public string pcfx__cpu_emulation { get; set; }
        public bool? pcfx__disable_bram { get; set; }
        public bool? pcfx__disable_softreset { get; set; }
        public string pcfx__fxscsi { get; set; }
        public string pcfx__high_dotclock_width { get; set; }
        public string pcfx__input__port1 { get; set; }
        public bool? pcfx__input__port1__multitap { get; set; }
        public string pcfx__input__port2 { get; set; }
        public bool? pcfx__input__port2__multitap { get; set; }
        public string pcfx__input__port3 { get; set; }
        public string pcfx__input__port4 { get; set; }
        public string pcfx__input__port5 { get; set; }
        public string pcfx__input__port6 { get; set; }
        public string pcfx__input__port7 { get; set; }
        public string pcfx__input__port8 { get; set; }
        public double? pcfx__mouse_sensitivity { get; set; }            // 0.3125 through 5
        public bool? pcfx__nospritelimit { get; set; }
        public bool? pcfx__rainbow__chromaip { get; set; }
        public int? pcfx__resamp_quality { get; set; }                  // 0 through 5
        public double? pcfx__resamp_rate_error { get; set; }             // 0.0000001 through 0.0000350
        public int? pcfx__slend { get; set; }                           // 0 through 239
        public int? pcfx__slstart { get; set; }                         // 0 through 239
        public string pcfx__debugger__disfontsize { get; set; }
        public string pcfx__debugger__memcharenc { get; set; }

        public bool? pcfx__enable { get; set; }
        public bool? pcfx__forcemono { get; set; }
        public string pcfx__shader { get; set; }
        public int? pcfx__scanlines { get; set; }
        public string pcfx__special { get; set; }
        public string pcfx__stretch { get; set; }
        public bool? pcfx__tblur { get; set; }
        public bool? pcfx__tblur__accum { get; set; }
        public double? pcfx__tblur__accum__amount { get; set; }
        public string pcfx__videoip { get; set; }
        public int? pcfx__xres { get; set; }                            // 0 through 65536
        public double? pcfx__xscale { get; set; }                       // 0.01 through 256
        public double? pcfx__xscalefs { get; set; }                     // 0.01 through 256
        public int? pcfx__yres { get; set; }                            // 0 through 65536
        public double? pcfx__yscale { get; set; }                       // 0.01 through 256
        public double? pcfx__yscalefs { get; set; }                     // 0.01 through 256

        public bool? pcfx__shader__goat__fprog { get; set; }
        public double? pcfx__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string pcfx__shader__goat__pat { get; set; }
        public bool? pcfx__shader__goat__slen { get; set; }
        public double? pcfx__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? pcfx__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        // Sega GameGear

        public bool? gg__enable { get; set; }
        public bool? gg__forcemono { get; set; }
        public string gg__shader { get; set; }
        public int? gg__scanlines { get; set; }
        public string gg__special { get; set; }
        public string gg__stretch { get; set; }
        public bool? gg__tblur { get; set; }
        public bool? gg__tblur__accum { get; set; }
        public double? gg__tblur__accum__amount { get; set; }
        public string gg__videoip { get; set; }
        public int? gg__xres { get; set; }                            // 0 through 65536
        public double? gg__xscale { get; set; }                       // 0.01 through 256
        public double? gg__xscalefs { get; set; }                     // 0.01 through 256
        public int? gg__yres { get; set; }                            // 0 through 65536
        public double? gg__yscale { get; set; }                       // 0.01 through 256
        public double? gg__yscalefs { get; set; }                     // 0.01 through 256

        public bool? gg__shader__goat__fprog { get; set; }
        public double? gg__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string gg__shader__goat__pat { get; set; }
        public bool? gg__shader__goat__slen { get; set; }
        public double? gg__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? gg__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        // Sega Master System
        public bool? sms__fm { get; set; }
        public string sms__territory { get; set; }

        public bool? sms__enable { get; set; }
        public bool? sms__forcemono { get; set; }
        public string sms__shader { get; set; }
        public int? sms__scanlines { get; set; }
        public string sms__special { get; set; }
        public string sms__stretch { get; set; }
        public bool? sms__tblur { get; set; }
        public bool? sms__tblur__accum { get; set; }
        public double? sms__tblur__accum__amount { get; set; }
        public string sms__videoip { get; set; }
        public int? sms__xres { get; set; }                            // 0 through 65536
        public double? sms__xscale { get; set; }                       // 0.01 through 256
        public double? sms__xscalefs { get; set; }                     // 0.01 through 256
        public int? sms__yres { get; set; }                            // 0 through 65536
        public double? sms__yscale { get; set; }                       // 0.01 through 256
        public double? sms__yscalefs { get; set; }                     // 0.01 through 256

        // mednafen version 0.9.41
        public int? sms__slstart { get; set; }
        public int? sms__slend { get; set; }
        public int? sms__slstartp { get; set; }
        public int? sms__slendp { get; set; }

        public bool? sms__shader__goat__fprog { get; set; }
        public double? sms__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string sms__shader__goat__pat { get; set; }
        public bool? sms__shader__goat__slen { get; set; }
        public double? sms__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? sms__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        // Sega Megadrive
        public string md__cdbios { get; set; }
        public bool? md__correct_aspect { get; set; }
        public bool? md__input__auto { get; set; }
        public double? md__input__mouse_sensitivity { get; set; }               // 0.25 through 4
        public string md__input__multitap { get; set; }
        public string md__input__port1 { get; set; }
        public string md__input__port2 { get; set; }
        public string md__input__port3 { get; set; }
        public string md__input__port4 { get; set; }
        public string md__input__port5 { get; set; }
        public string md__input__port6 { get; set; }
        public string md__input__port7 { get; set; }
        public string md__input__port8 { get; set; }
        public string md__region { get; set; }
        public string md__reported_region { get; set; }
        public string md__debugger__disfontsize { get; set; }
        public string md__debugger__memcharenc { get; set; }

        public bool? md__enable { get; set; }
        public bool? md__forcemono { get; set; }
        public string md__shader { get; set; }
        public int? md__scanlines { get; set; }
        public string md__special { get; set; }
        public string md__stretch { get; set; }
        public bool? md__tblur { get; set; }
        public bool? md__tblur__accum { get; set; }
        public double? md__tblur__accum__amount { get; set; }
        public string md__videoip { get; set; }
        public int? md__xres { get; set; }                            // 0 through 65536
        public double? md__xscale { get; set; }                       // 0.01 through 256
        public double? md__xscalefs { get; set; }                     // 0.01 through 256
        public int? md__yres { get; set; }                            // 0 through 65536
        public double? md__yscale { get; set; }                       // 0.01 through 256
        public double? md__yscalefs { get; set; }                     // 0.01 through 256

        public bool? md__shader__goat__fprog { get; set; }
        public double? md__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string md__shader__goat__pat { get; set; }
        public bool? md__shader__goat__slen { get; set; }
        public double? md__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? md__shader__goat__vdiv { get; set; }           // -2.00 through 2.00


        // Sega Saturn
        public string ss__bios_jp { get; set; }
        public string ss__bios_na_eu { get; set; }
        public bool? ss__bios_sanity { get; set; }
        public string ss__cart { get; set; }
        public string ss__cart__kof95_path { get; set; }
        public string ss__cart__ultraman_path { get; set; }
        public bool? ss__cd_sanity { get; set; }
        public double? ss__input__mouse_sensitivity { get; set; }           // 0.125 through 2
        public string ss__input__port1 { get; set; }
        public string ss__input__port1__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public string ss__input__port2 { get; set; }
        public string ss__input__port2__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public string ss__input__port3 { get; set; }
        public string ss__input__port3__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public string ss__input__port4 { get; set; }
        public string ss__input__port4__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public string ss__input__port5 { get; set; }
        public string ss__input__port5__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public string ss__input__port6 { get; set; }
        public string ss__input__port6__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public string ss__input__port7 { get; set; }
        public string ss__input__port7__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public string ss__input__port8 { get; set; }
        public string ss__input__port8__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public string ss__input__port9 { get; set; }
        public string ss__input__port9__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public string ss__input__port10 { get; set; }
        public string ss__input__port10__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public string ss__input__port11 { get; set; }
        public string ss__input__port11__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public string ss__input__port12 { get; set; }
        public string ss__input__port12__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public bool? ss__midsync { get; set; }
        public bool? ss__region_autodetect { get; set; }
        public string ss__region_default { get; set; }
        public int? ss__scsp__resamp_quality { get; set; }                  // 0 through 10
        public int? ss__slend { get; set; }                                 //0 through 239
        public int? ss__slendp { get; set; }                                // -16 through 271
        public int? ss__slstart { get; set; }                                 //0 through 239
        public int? ss__slstartp { get; set; }                                // -16 through 271
        public bool? ss__smpc__autortc { get; set; }
        public string ss__smpc__autortc__lang { get; set; }
        public string ss__debugger__disfontsize { get; set; }
        public string ss__debugger__memcharenc { get; set; }

        /* moved into CONTROLS section - 2018-03-01
        public string ss__input__port1__3dpad__mode__defpos { get; set; }
        public string ss__input__port2__3dpad__mode__defpos { get; set; }
        public string ss__input__port3__3dpad__mode__defpos { get; set; }
        public string ss__input__port4__3dpad__mode__defpos { get; set; }
        public string ss__input__port5__3dpad__mode__defpos { get; set; }
        public string ss__input__port6__3dpad__mode__defpos { get; set; }
        public string ss__input__port7__3dpad__mode__defpos { get; set; }
        public string ss__input__port8__3dpad__mode__defpos { get; set; }
        public string ss__input__port9__3dpad__mode__defpos { get; set; }
        public string ss__input__port10__3dpad__mode__defpos { get; set; }
        public string ss__input__port11__3dpad__mode__defpos { get; set; }
        public string ss__input__port12__3dpad__mode__defpos { get; set; }
        */

        public bool? ss__enable { get; set; }
        public bool? ss__forcemono { get; set; }
        public string ss__shader { get; set; }
        public int? ss__scanlines { get; set; }
        public string ss__special { get; set; }
        public string ss__stretch { get; set; }
        public bool? ss__tblur { get; set; }
        public bool? ss__tblur__accum { get; set; }
        public double? ss__tblur__accum__amount { get; set; }
        public string ss__videoip { get; set; }
        public int? ss__xres { get; set; }                            // 0 through 65536
        public double? ss__xscale { get; set; }                       // 0.01 through 256
        public double? ss__xscalefs { get; set; }                     // 0.01 through 256
        public int? ss__yres { get; set; }                            // 0 through 65536
        public double? ss__yscale { get; set; }                       // 0.01 through 256
        public double? ss__yscalefs { get; set; }                     // 0.01 through 256

        public bool? ss__input__sport1__multitap { get; set; }
        public bool? ss__input__sport2__multitap { get; set; }

        // added controls mednafen 0.9.41
        public bool? ss__correct_aspect { get; set; }
        public bool? ss__h_blend { get; set; }
        public bool? ss__h_overscan { get; set; }

        public bool? ss__shader__goat__fprog { get; set; }
        public double? ss__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string ss__shader__goat__pat { get; set; }
        public bool? ss__shader__goat__slen { get; set; }
        public double? ss__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? ss__shader__goat__vdiv { get; set; }           // -2.00 through 2.00


        // Sony Playstation
        public string psx__bios_eu { get; set; }
        public string psx__bios_jp { get; set; }
        public string psx__bios_na { get; set; }
        public bool? psx__bios_sanity { get; set; }
        public bool? psx__cd_sanity { get; set; }
        public int? psx__dbg_level { get; set; }                            // 0 through 4
        public bool? psx__h_overscan { get; set; }
        public bool? psx__input__analog_mode_ct { get; set; }
        public double? psx__input__mouse_sensitivity { get; set; }         // 0.25 through 4

        public string psx__input__port1 { get; set; }
        /* removed 2018-03-01
        public double? psx__input__port1__analogjoy__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port1__dualanalog__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port1__dualshock__axis_scale { get; set; }       // 1 through 1.5
        */
        public string psx__input__port1__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public bool? psx__input__port1__memcard { get; set; }

        public string psx__input__port2 { get; set; }
        /* removed 2018-03-01
        public double? psx__input__port2__analogjoy__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port2__dualanalog__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port2__dualshock__axis_scale { get; set; }       // 1 through 1.5
        */
        public string psx__input__port2__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public bool? psx__input__port2__memcard { get; set; }

        public string psx__input__port3 { get; set; }
        /* removed 2018-03-01
        public double? psx__input__port3__analogjoy__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port3__dualanalog__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port3__dualshock__axis_scale { get; set; }       // 1 through 1.5
        */
        public string psx__input__port3__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public bool? psx__input__port3__memcard { get; set; }

        public string psx__input__port4 { get; set; }
        /* removed 2018-03-01
        public double? psx__input__port4__analogjoy__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port4__dualanalog__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port4__dualshock__axis_scale { get; set; }       // 1 through 1.5
        */
        public string psx__input__port4__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public bool? psx__input__port4__memcard { get; set; }

        public string psx__input__port5 { get; set; }
        /* removed 2018-03-01
        public double? psx__input__port5__analogjoy__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port5__dualanalog__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port5__dualshock__axis_scale { get; set; }       // 1 through 1.5
        */
        public string psx__input__port5__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public bool? psx__input__port5__memcard { get; set; }

        public string psx__input__port6 { get; set; }
        /* removed 2018-03-01
        public double? psx__input__port6__analogjoy__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port6__dualanalog__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port6__dualshock__axis_scale { get; set; }       // 1 through 1.5
        */
        public string psx__input__port6__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public bool? psx__input__port6__memcard { get; set; }

        public string psx__input__port7 { get; set; }
        /* removed 2018-03-01
        public double? psx__input__port7__analogjoy__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port7__dualanalog__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port7__dualshock__axis_scale { get; set; }       // 1 through 1.5
        */
        public string psx__input__port7__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public bool? psx__input__port7__memcard { get; set; }

        public string psx__input__port8 { get; set; }
        /* removed 2018-03-01
        public double? psx__input__port8__analogjoy__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port8__dualanalog__axis_scale { get; set; }       // 1 through 1.5
        public double? psx__input__port8__dualshock__axis_scale { get; set; }       // 1 through 1.5
        */
        public string psx__input__port8__gun_chairs { get; set; }                     // 0x000000 through 0x1000000
        public bool? psx__input__port8__memcard { get; set; }

        public bool? psx__input__pport1__multitap { get; set; }
        public bool? psx__input__pport2__multitap { get; set; }
        public bool? psx__region_autodetect { get; set; }
        public string psx__region_default { get; set; }
        public int? psx__slend { get; set; }                                // 0 through 239
        public int? psx__slendp { get; set; }                               // 0 through 287
        public int? psx__slstart { get; set; }                                // 0 through 239
        public int? psx__slstartp { get; set; }                               // 0 through 287
        public int? psx__spu__resamp_quality { get; set; }                      // 0 through 10

        public string psx__debugger__disfontsize { get; set; }
        public string psx__debugger__memcharenc { get; set; }

        public bool? psx__enable { get; set; }
        public bool? psx__forcemono { get; set; }
        public string psx__shader { get; set; }
        public int? psx__scanlines { get; set; }
        public string psx__special { get; set; }
        public string psx__stretch { get; set; }
        public bool? psx__tblur { get; set; }
        public bool? psx__tblur__accum { get; set; }
        public double? psx__tblur__accum__amount { get; set; }
        public string psx__videoip { get; set; }
        public int? psx__xres { get; set; }                            // 0 through 65536
        public double? psx__xscale { get; set; }                       // 0.01 through 256
        public double? psx__xscalefs { get; set; }                     // 0.01 through 256
        public int? psx__yres { get; set; }                            // 0 through 65536
        public double? psx__yscale { get; set; }                       // 0.01 through 256
        public double? psx__yscalefs { get; set; }                     // 0.01 through 256

        public string psx__input__analog_mode_ct__compare { get; set; }

        public bool? psx__shader__goat__fprog { get; set; }
        public double? psx__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string psx__shader__goat__pat { get; set; }
        public bool? psx__shader__goat__slen { get; set; }
        public double? psx__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? psx__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        public bool? psx_shared_memcards { get; set; }

        // SNES (Faust)

        public bool? snes_faust__correct_aspect { get; set; }

        public bool snes_faust__input__sport1__multitap { get; set; }
        public bool snes_faust__input__sport2__multitap { get; set; }

        public string snes_faust__input__port1 { get; set; }
        public string snes_faust__input__port2 { get; set; }
        public string snes_faust__input__port3 { get; set; }
        public string snes_faust__input__port4 { get; set; }
        public string snes_faust__input__port5 { get; set; }
        public string snes_faust__input__port6 { get; set; }
        public string snes_faust__input__port7 { get; set; }
        public string snes_faust__input__port8 { get; set; }
        public int? snes_faust__resamp_quality { get; set; }                    // 0 through 5
        public double? snes_faust__resamp_rate_error { get; set; }              // 0.0000001 through 0.0015
        public bool? snes_faust__spex { get; set; }
        public bool? snes_faust__spex__sound { get; set; }

        public bool? snes_faust__enable { get; set; }
        public bool? snes_faust__forcemono { get; set; }
        public string snes_faust__shader { get; set; }
        public int? snes_faust__scanlines { get; set; }
        public string snes_faust__special { get; set; }
        public string snes_faust__stretch { get; set; }
        public bool? snes_faust__tblur { get; set; }
        public bool? snes_faust__tblur__accum { get; set; }
        public double? snes_faust__tblur__accum__amount { get; set; }
        public string snes_faust__videoip { get; set; }
        public int? snes_faust__xres { get; set; }                            // 0 through 65536
        public double? snes_faust__xscale { get; set; }                       // 0.01 through 256
        public double? snes_faust__xscalefs { get; set; }                     // 0.01 through 256
        public int? snes_faust__yres { get; set; }                            // 0 through 65536
        public double? snes_faust__yscale { get; set; }                       // 0.01 through 256
        public double? snes_faust__yscalefs { get; set; }                     // 0.01 through 256

        public bool? snes_faust__shader__goat__fprog { get; set; }
        public double? snes_faust__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string snes_faust__shader__goat__pat { get; set; }
        public bool? snes_faust__shader__goat__slen { get; set; }
        public double? snes_faust__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? snes_faust__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        // SNES
        public int? snes__apu__resamp_quality { get; set; }                     // 0 through 10
        public bool? snes__correct_aspect { get; set; }        
        public bool? snes__input__port1__multitap { get; set; }
        public bool? snes__input__port2__multitap { get; set; }
        public string snes__input__port1 { get; set; }
        public string snes__input__port2 { get; set; }
        /*
        public string snes__input__port3 { get; set; }
        public string snes__input__port4 { get; set; }
        public string snes__input__port5 { get; set; }
        public string snes__input__port6 { get; set; }
        public string snes__input__port7 { get; set; }
        public string snes__input__port8 { get; set; }  
        */

        public double? snes__mouse_sensitivity { get; set; }                    // 0.125 through 2

        public bool? snes__enable { get; set; }
        public bool? snes__forcemono { get; set; }
        public string snes__shader { get; set; }
        public int? snes__scanlines { get; set; }
        public string snes__special { get; set; }
        public string snes__stretch { get; set; }
        public bool? snes__tblur { get; set; }
        public bool? snes__tblur__accum { get; set; }
        public double? snes__tblur__accum__amount { get; set; }
        public string snes__videoip { get; set; }
        public int? snes__xres { get; set; }                            // 0 through 65536
        public double? snes__xscale { get; set; }                       // 0.01 through 256
        public double? snes__xscalefs { get; set; }                     // 0.01 through 256
        public int? snes__yres { get; set; }                            // 0 through 65536
        public double? snes__yscale { get; set; }                       // 0.01 through 256
        public double? snes__yscalefs { get; set; }                     // 0.01 through 256

        public bool? snes__shader__goat__fprog { get; set; }
        public double? snes__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string snes__shader__goat__pat { get; set; }
        public bool? snes__shader__goat__slen { get; set; }
        public double? snes__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? snes__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        public bool? snes__h_blend { get; set; }



        // Virtual Boy
        public string vb__3dmode { get; set; }
        public bool? vb__3dreverse { get; set; }
        public bool? vb__allow_draw_skip { get; set; }
        public string vb__anaglyph__lcolor { get; set; }
        public string vb__anaglyph__preset { get; set; }
        public string vb__anaglyph__rcolor { get; set; }
        public string vb__cpu_emulation { get; set; }
        public string vb__default_color { get; set; }
        public bool? vb__disable_parallax { get; set; }
        public bool? vb__input__instant_read_hack { get; set; }
        public bool? vb__instant_display_hack { get; set; }
        public int? vb__liprescale { get; set; }                                // 1 through 10
        public int? vb__sidebyside__separation { get; set; }                    // 0 though 1024

        public string vb__debugger__disfontsize { get; set; }
        public string vb__debugger__memcharenc { get; set; }

        public bool? vb__enable { get; set; }
        public bool? vb__forcemono { get; set; }
        public string vb__shader { get; set; }
        public int? vb__scanlines { get; set; }
        public string vb__special { get; set; }
        public string vb__stretch { get; set; }
        public bool? vb__tblur { get; set; }
        public bool? vb__tblur__accum { get; set; }
        public double? vb__tblur__accum__amount { get; set; }
        public string vb__videoip { get; set; }
        public int? vb__xres { get; set; }                            // 0 through 65536
        public double? vb__xscale { get; set; }                       // 0.01 through 256
        public double? vb__xscalefs { get; set; }                     // 0.01 through 256
        public int? vb__yres { get; set; }                            // 0 through 65536
        public double? vb__yscale { get; set; }                       // 0.01 through 256
        public double? vb__yscalefs { get; set; }                     // 0.01 through 256

        public double? vb__ledonscale { get; set; }                   // 1 through 2    

        public bool? vb__shader__goat__fprog { get; set; }
        public double? vb__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string vb__shader__goat__pat { get; set; }
        public bool? vb__shader__goat__slen { get; set; }
        public double? vb__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? vb__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        // WonderSwan
        public int? wswan__bday { get; set; }                                   // 1 through 31
        public string wswan__blood { get; set; }
        public int? wswan__bmonth { get; set; }                                 // 1 though 12
        public int? wswan__byear { get; set; }                                  // 0 through 9999
        public string wswan__language { get; set; }
        public string wswan__name { get; set; }
        //public bool? wswan__rotateinput { get; set; }
        public string wswan__sex { get; set; }

        public bool? wswan__enable { get; set; }
        public bool? wswan__forcemono { get; set; }
        public string wswan__shader { get; set; }
        public int? wswan__scanlines { get; set; }
        public string wswan__special { get; set; }
        public string wswan__stretch { get; set; }
        public bool? wswan__tblur { get; set; }
        public bool? wswan__tblur__accum { get; set; }
        public double? wswan__tblur__accum__amount { get; set; }
        public string wswan__videoip { get; set; }
        public int? wswan__xres { get; set; }                            // 0 through 65536
        public double? wswan__xscale { get; set; }                       // 0.01 through 256
        public double? wswan__xscalefs { get; set; }                     // 0.01 through 256
        public int? wswan__yres { get; set; }                            // 0 through 65536
        public double? wswan__yscale { get; set; }                       // 0.01 through 256
        public double? wswan__yscalefs { get; set; }                     // 0.01 through 256

        public string wswan__debugger__disfontsize { get; set; }
        public string wswan__debugger__memcharenc { get; set; }

        public bool? wswan__shader__goat__fprog { get; set; }
        public double? wswan__shader__goat__hdiv { get; set; }           // -2.00 through 2.00
        public string wswan__shader__goat__pat { get; set; }
        public bool? wswan__shader__goat__slen { get; set; }
        public double? wswan__shader__goat__tp { get; set; }              // 0.00 through 1.00
        public double? wswan__shader__goat__vdiv { get; set; }           // -2.00 through 2.00

        public string wswan__input__builtin { get; set; }

        public static ConfigBaseSettings GetConfigDefaults()
        {
            ConfigBaseSettings cfbs = new ConfigBaseSettings
            {
                UpdatedTime = DateTime.Now,
                systemIdent = 0,
                isEnabled = true,

                autosave = false,                                   // control placed
                cd__image_memcache = false,                         // control placed
                cheats = true,                                      // control placed
                debugger__autostepmode = false,
                ffnosound = false,                                  // control placed
                ffspeed = 4,                                        // control placed
                fftoggle = false,                                   // control placed

                filesys__path_cheat = "cheats",
                filesys__path_firmware = "firmware",
                filesys__path_movie = "mcm",
                filesys__path_palette = "palettes",
                filesys__path_pgconfig = "pgconfig",
                filesys__path_sav = "sav",
                filesys__path_savbackup = "b",
                filesys__path_snap = "snaps",
                filesys__path_state = "mcs",

                filesys__state_comp_level = 6,
                filesys__untrusted_fip_check = true,
                input__autofirefreq = 3,                            // control placed
                input__ckdelay = 0,                                 // control placed
                input__joystick__axis_threshold = 75.00,               // control placed
                input__joystick__global_focus = true,               // control placed
                nothrottle = false,                                 // control placed
                osd__alpha_blend = true,                            // control placed
                osd__message_display_time = 2500,                   // control placed
                osd__state_display_time = 2000,                     // control placed

                // new FPS options
                fps__autoenable = false,
                fps__bgcolor = "0x80000000",
                fps__font = "5x7",
                fps__position = "upper_left",
                fps__scale = 1,
                fps__textcolor = "0xFFFFFFFF",


                qtrecord__h_double_threshold = 256,
                qtrecord__w_double_threshold = 384,
                qtrecord__vcodec = "cscd",
                sfspeed = 0.75,                                     // control placed
                sftoggle = false,                                   // control placed
                sound = true,                                       // control placed
                sound__buffer_time = 0,                             // control placed
                sound__device = "default",
                sound__driver = "default",                          // control placed
                sound__period_time = 0,                             // control placed
                sound__rate = 48000,                                // control placed
                sound__volume = 100,                                // control placed
                srwframes = 600,                                    // control placed
                video__blit_timesync = true,                        // control placed
                video__deinterlacer = "weave",                      // control placed
                video__disable_composition = true,                  // control placed
                video__driver = "default",                           // control placed
                video__frameskip = true,                            // control placed
                video__fs = false,                                  // control placed
                video__glvsync = true,                              // control placed

                video__fs__display = -1,                          // -1 through 32767

                // generic system specific settings
                __enable = true,
                __forcemono = false,                                // control placed
                __shader = "none",                               // control placed
                __scanlines = 0,                                    // control placed
                __special = "none",                                 // control placed
                __stretch = "aspect_mult2",                         // control placed
                __tblur = false,                                    // control placed
                __tblur__accum = false,                             // control placed
                __tblur__accum__amount = 50,                        // control placed
                __videoip = "0",                                    // control placed
                __xres = 0,                                         // control placed
                __xscale = 1,                                       // control placed
                __xscalefs = 1,                                     // control placed
                __yres = 0,                                         // control placed
                __yscale = 1,                                       // control placed
                __yscalefs = 1,                                      // control placed

                

                // system specific settings

                // lynx
                lynx__lowpass = true,                                   // placed
                lynx__rotateinput = true,                               // placed

                lynx__enable = true,
                lynx__forcemono = false,                                // control placed
                lynx__shader = "none",                               // control placed
                lynx__scanlines = 0,                                    // control placed
                lynx__special = "none",                                 // control placed
                lynx__stretch = "aspect_mult2",                         // control placed
                lynx__tblur = false,                                    // control placed
                lynx__tblur__accum = false,                             // control placed
                lynx__tblur__accum__amount = 50,                        // control placed
                lynx__videoip = "0",                                    // control placed
                lynx__xres = 0,                                         // control placed
                lynx__xscale = 6,                                       // control placed
                lynx__xscalefs = 1,                                     // control placed
                lynx__yres = 0,                                         // control placed
                lynx__yscale = 6,                                       // control placed
                lynx__yscalefs = 1,                                     // control placed

                lynx__shader__goat__fprog = false,
                lynx__shader__goat__hdiv = 0.50,
                lynx__shader__goat__pat = "goatron",
                lynx__shader__goat__slen = true,
                lynx__shader__goat__tp = 0.50,
                lynx__shader__goat__vdiv = 0.50,

                // gameboy
                gb__system_type = "auto",                               // placed

                gb__enable = true,
                gb__forcemono = false,                                // control placed
                gb__shader = "none",                               // control placed
                gb__scanlines = 0,                                    // control placed
                gb__special = "none",                                 // control placed
                gb__stretch = "aspect_mult2",                         // control placed
                gb__tblur = false,                                    // control placed
                gb__tblur__accum = false,                             // control placed
                gb__tblur__accum__amount = 50,                        // control placed
                gb__videoip = "0",                                    // control placed
                gb__xres = 0,                                         // control placed
                gb__xscale = 6,                                       // control placed
                gb__xscalefs = 1,                                     // control placed
                gb__yres = 0,                                         // control placed
                gb__yscale = 6,                                       // control placed
                gb__yscalefs = 1,                                     // control placed

                gb__shader__goat__fprog = false,
                gb__shader__goat__hdiv = 0.50,
                gb__shader__goat__pat = "goatron",
                gb__shader__goat__slen = true,
                gb__shader__goat__tp = 0.50,
                gb__shader__goat__vdiv = 0.50,

                // gameboy advance
                gba__bios = "",

                gba__enable = true,
                gba__forcemono = false,                                // control placed
                gba__shader = "none",                               // control placed
                gba__scanlines = 0,                                    // control placed
                gba__special = "none",                                 // control placed
                gba__stretch = "aspect_mult2",                         // control placed
                gba__tblur = false,                                    // control placed
                gba__tblur__accum = false,                             // control placed
                gba__tblur__accum__amount = 50,                        // control placed
                gba__videoip = "0",                                    // control placed
                gba__xres = 0,                                         // control placed
                gba__xscale = 4,                                       // control placed
                gba__xscalefs = 1,                                     // control placed
                gba__yres = 0,                                         // control placed
                gba__yscale = 4,                                       // control placed
                gba__yscalefs = 1,                                     // control placed

                gba__shader__goat__fprog = false,
                gba__shader__goat__hdiv = 0.50,
                gba__shader__goat__pat = "goatron",
                gba__shader__goat__slen = true,
                gba__shader__goat__tp = 0.50,
                gba__shader__goat__vdiv = 0.50,

                // neogeo pocket
                npg__language = "english",                              // placed

                ngp__enable = true,
                ngp__forcemono = false,                                // control placed
                ngp__shader = "none",                               // control placed
                ngp__scanlines = 0,                                    // control placed
                ngp__special = "none",                                 // control placed
                ngp__stretch = "aspect_mult2",                         // control placed
                ngp__tblur = false,                                    // control placed
                ngp__tblur__accum = false,                             // control placed
                ngp__tblur__accum__amount = 50,                        // control placed
                ngp__videoip = "0",                                    // control placed
                ngp__xres = 0,                                         // control placed
                ngp__xscale = 6,                                       // control placed
                ngp__xscalefs = 1,                                     // control placed
                ngp__yres = 0,                                         // control placed
                ngp__yscale = 6,                                       // control placed
                ngp__yscalefs = 1,                                     // control placed

                ngp__shader__goat__fprog = false,
                ngp__shader__goat__hdiv = 0.50,
                ngp__shader__goat__pat = "goatron",
                ngp__shader__goat__slen = true,
                ngp__shader__goat__tp = 0.50,
                ngp__shader__goat__vdiv = 0.50,

                // NES
                nes__clipsides = false,                                 // placed
                nes__correct_aspect = false,                            // placed
                nes__fnscan = true,                                     // placed
                nes__gg = false,                                        // placed
                nes__ggrom = "gg.rom",
                nes__input__fcexp = "none",                             // placed
                nes__input__port1 = "gamepad",                          // placed
                nes__input__port2 = "gamepad",                          // placed
                nes__input__port3 = "gamepad",                          // placed
                nes__input__port4 = "gamepad",                          // placed
                nes__n106bs = false,                                    // placed
                nes__no8lim = false,                                    // placed
                nes__nofs = false,                                      // placed
                nes__ntsc__brightness = 0,                              // placed
                nes__ntsc__contrast = 0,                                // placed
                nes__ntsc__hue = 0,                                     // placed
                nes__ntsc__matrix = false,                              // placed
                nes__ntsc__matrix__0 = 1.539,                           // placed
                nes__ntsc__matrix__1 = -0.622,                          // placed
                nes__ntsc__matrix__2 = -0.571,                          // placed
                nes__ntsc__matrix__3 = -0.185,                          // placed
                nes__ntsc__matrix__4 = 0,                               // placed
                nes__ntsc__matrix__5 = 2,                               // placed
                nes__ntsc__mergefields = false,                         // placed
                nes__ntsc__preset = "disabled",                         // placed
                nes__ntsc__saturation = 0,                              // placed
                nes__ntsc__sharpness = 0,                               // placed
                nes__ntscblitter = false,                               // placed
                nes__pal = false,                                       // placed
                nes__slend = 231,                                       // placed
                nes__slendp = 239,                                      // placed
                nes__slstart = 8,                                       // placed
                nes__slstartp = 0,                                      // placed
                nes__sound_rate_error = 0.00004,                        // placed
                nes__soundq = 0,                                        // placed
                nes__debugger__disfontsize = "5x7",                      // placed
                nes__debugger__memcharenc = "cp437",                     // placed

                nes__enable = true,
                nes__shader = "none",                               // control placed
                nes__scanlines = 0,                                    // control placed
                nes__special = "none",                                 // control placed
                nes__stretch = "aspect_mult2",                         // control placed
                nes__tblur = false,                                    // control placed
                nes__tblur__accum = false,                             // control placed
                nes__tblur__accum__amount = 50,                        // control placed
                nes__videoip = "0",                                    // control placed
                nes__xres = 0,                                         // control placed
                nes__xscale = 4,                                       // control placed
                nes__xscalefs = 1,                                     // control placed
                nes__yres = 0,                                         // control placed
                nes__yscale = 4,                                       // control placed
                nes__yscalefs = 1,                                     // control placed

                nes__shader__goat__fprog = false,
                nes__shader__goat__hdiv = 0.50,
                nes__shader__goat__pat = "goatron",
                nes__shader__goat__slen = true,
                nes__shader__goat__tp = 0.50,
                nes__shader__goat__vdiv = 0.50,

                // PCE fast
                pce_fast__adpcmlp = false,                              // placed
                pce_fast__adpcmvolume = 100,                            // placed
                pce_fast__arcadecard = true,                            // placed
                pce_fast__cdbios = "syscard3.pce",
                pce_fast__cddavolume = 100,                             // placed
                pce_fast__cdpsgvolume = 100,                            // placed
                pce_fast__cdspeed = 1,                                  // placed
                pce_fast__correct_aspect = true,                        // placed
                pce_fast__disable_softreset = false,                    // placed
                pce_fast__forcesgx = false,                             // placed
                pce_fast__input__port1 = "gamepad",                     // placed
                pce_fast__input__port2 = "gamepad",                     // placed
                pce_fast__input__port3 = "gamepad",                     // placed
                pce_fast__input__port4 = "gamepad",                     // placed
                pce_fast__input__port5 = "gamepad",                     // placed
                pce_fast__mouse_sensitivity = 0.5,                      // placed
                pce_fast__nospritelimit = false,                        // placed
                pce_fast__ocmultiplier = 1,                             // placed
                pce_fast__slend = 235,                                  // placed
                pce_fast__slstart = 4,                                  // placed
                pce__debugger__disfontsize = "5x7",                      // placed
                pce__debugger__memcharenc = "shift_jis",                 // placed

                pce_fast__enable = true,
                pce_fast__forcemono = false,                                // control placed
                pce_fast__shader = "none",                               // control placed
                pce_fast__scanlines = 0,                                    // control placed
                pce_fast__special = "none",                                 // control placed
                pce_fast__stretch = "aspect_mult2",                         // control placed
                pce_fast__tblur = false,                                    // control placed
                pce_fast__tblur__accum = false,                             // control placed
                pce_fast__tblur__accum__amount = 50,                        // control placed
                pce_fast__videoip = "1",                                    // control placed
                pce_fast__xres = 0,                                         // control placed
                pce_fast__xscale = 3,                                       // control placed
                pce_fast__xscalefs = 1,                                     // control placed
                pce_fast__yres = 0,                                         // control placed
                pce_fast__yscale = 3,                                       // control placed
                pce_fast__yscalefs = 1,                                     // control placed

                pce_fast__shader__goat__fprog = false,
                pce_fast__shader__goat__hdiv = 0.50,
                pce_fast__shader__goat__pat = "goatron",
                pce_fast__shader__goat__slen = true,
                pce_fast__shader__goat__tp = 0.50,
                pce_fast__shader__goat__vdiv = 0.50,

                // PCE
                pce__adpcmextraprec = false,                            // placed
                pce__adpcmvolume = 100,                                 // placed
                pce__arcadecard = true,                                 // placed
                pce__cdbios = "syscard3.pce",
                pce__cddavolume = 100,                                  // placed
                pce__cdpsgvolume = 100,                                 // placed
                pce__disable_bram_cd = false,                           // placed
                pce__disable_bram_hucard = false,                       // placed
                pce__disable_softreset = false,                         // placed
                pce__forcesgx = false,                                  // placed
                pce__gecdbios = "gecard.pce",
                pce__h_overscan = false,                                // placed
                pce__input__multitap = true,                            // placed
                pce__input__port1 = "gamepad",                          // placed
                pce__input__port2 = "gamepad",                          // placed
                pce__input__port3 = "gamepad",                          // placed
                pce__input__port4 = "gamepad",                          // placed
                pce__input__port5 = "gamepad",                          // placed
                pce__mouse_sensitivity = 0.5,                           // placed
                pce__nospritelimit = false,                             // placed
                pce__psgrevision = "match",                             // placed
                pce__resamp_quality = 3,
                pce__resamp_rate_error = 0.0000009,
                pce__slend = 235,
                pce__slstart = 4,

                pce__shader__goat__fprog = false,
                pce__shader__goat__hdiv = 0.50,
                pce__shader__goat__pat = "goatron",
                pce__shader__goat__slen = true,
                pce__shader__goat__tp = 0.50,
                pce__shader__goat__vdiv = 0.50,

                pce__enable = true,
                pce__forcemono = false,                                // control placed
                pce__shader = "none",                               // control placed
                pce__scanlines = 0,                                    // control placed
                pce__special = "none",                                 // control placed
                pce__stretch = "aspect_mult2",                         // control placed
                pce__tblur = false,                                    // control placed
                pce__tblur__accum = false,                             // control placed
                pce__tblur__accum__amount = 50,                        // control placed
                pce__videoip = "1",                                    // control placed
                pce__xres = 0,                                         // control placed
                pce__xscale = 3,                                       // control placed
                pce__xscalefs = 1,                                     // control placed
                pce__yres = 0,                                         // control placed
                pce__yscale = 3,                                       // control placed
                pce__yscalefs = 1,                                     // control placed

                // PC-FX
                pcfx__adpcm__emulate_buggy_codec = false,                   // placed
                pcfx__adpcm__suppress_channel_reset_clicks = true,          // placed
                pcfx__bios = "pcfx.rom",
                pcfx__cdspeed = 2,                                          // placed
                pcfx__cpu_emulation = "auto",                               // placed
                pcfx__disable_bram = false,                                 // placed
                pcfx__disable_softreset = false,                            // placed
                pcfx__fxscsi = null,
                pcfx__high_dotclock_width = "1024",                         // placed
                pcfx__input__port1 = "gamepad",                             // placed
                pcfx__input__port1__multitap = false,                       // placed
                pcfx__input__port2 = "gamepad",                             // placed
                pcfx__input__port2__multitap = false,                       // placed
                pcfx__input__port3 = "gamepad",                             // placed
                pcfx__input__port4 = "gamepad",                             // placed
                pcfx__input__port5 = "gamepad",                             // placed
                pcfx__input__port6 = "gamepad",                             // placed
                pcfx__input__port7 = "gamepad",                             // placed
                pcfx__input__port8 = "gamepad",                             // placed
                pcfx__mouse_sensitivity = 1.25,                             // placed
                pcfx__nospritelimit = false,                                // placed
                pcfx__rainbow__chromaip = false,                            // placed
                pcfx__resamp_quality = 3,                                   // placed
                pcfx__resamp_rate_error = 0.0000009,                        // placed
                pcfx__slend = 235,                                          // placed
                pcfx__slstart = 4,                                          // placed
                pcfx__debugger__disfontsize = "5x7",                         // palced
                pcfx__debugger__memcharenc = "shift_jis",                    // placed

                pcfx__enable = true,
                pcfx__forcemono = false,                                // control placed
                pcfx__shader = "none",                               // control placed
                pcfx__scanlines = 0,                                    // control placed
                pcfx__special = "none",                                 // control placed
                pcfx__stretch = "aspect_mult2",                         // control placed
                pcfx__tblur = false,                                    // control placed
                pcfx__tblur__accum = false,                             // control placed
                pcfx__tblur__accum__amount = 50,                        // control placed
                pcfx__videoip = "1",                                    // control placed
                pcfx__xres = 0,                                         // control placed
                pcfx__xscale = 3,                                       // control placed
                pcfx__xscalefs = 1,                                     // control placed
                pcfx__yres = 0,                                         // control placed
                pcfx__yscale = 3,                                       // control placed
                pcfx__yscalefs = 1,                                     // control placed

                pcfx__shader__goat__fprog = false,
                pcfx__shader__goat__hdiv = 0.50,
                pcfx__shader__goat__pat = "goatron",
                pcfx__shader__goat__slen = true,
                pcfx__shader__goat__tp = 0.50,
                pcfx__shader__goat__vdiv = 0.50,

                // Game Gear

                gg__enable = true,
                gg__forcemono = false,                                // control placed
                gg__shader = "none",                               // control placed
                gg__scanlines = 0,                                    // control placed
                gg__special = "none",                                 // control placed
                gg__stretch = "aspect_mult2",                         // control placed
                gg__tblur = false,                                    // control placed
                gg__tblur__accum = false,                             // control placed
                gg__tblur__accum__amount = 50,                        // control placed
                gg__videoip = "0",                                    // control placed
                gg__xres = 0,                                         // control placed
                gg__xscale = 6,                                       // control placed
                gg__xscalefs = 1,                                     // control placed
                gg__yres = 0,                                         // control placed
                gg__yscale = 6,                                       // control placed
                gg__yscalefs = 1,                                     // control placed

                gg__shader__goat__fprog = false,
                gg__shader__goat__hdiv = 0.50,
                gg__shader__goat__pat = "goatron",
                gg__shader__goat__slen = true,
                gg__shader__goat__tp = 0.50,
                gg__shader__goat__vdiv = 0.50,

                // Mster system
                sms__fm = true,                                             // placed
                sms__territory = "export",                                   // placed

                sms__enable = true,
                sms__forcemono = false,                                // control placed
                sms__shader = "none",                               // control placed
                sms__scanlines = 0,                                    // control placed
                sms__special = "none",                                 // control placed
                sms__stretch = "aspect_mult2",                         // control placed
                sms__tblur = false,                                    // control placed
                sms__tblur__accum = false,                             // control placed
                sms__tblur__accum__amount = 50,                        // control placed
                sms__videoip = "0",                                    // control placed
                sms__xres = 0,                                         // control placed
                sms__xscale = 4,                                       // control placed
                sms__xscalefs = 1,                                     // control placed
                sms__yres = 0,                                         // control placed
                sms__yscale = 4,                                       // control placed
                sms__yscalefs = 1,                                     // control placed

                sms__slend = 239,                                        // control placed
                sms__slendp = 239,                                       // control placed
                sms__slstartp = 0,                                       // control placed
                sms__slstart = 0,                                       // control placed

                sms__shader__goat__fprog = false,
                sms__shader__goat__hdiv = 0.50,
                sms__shader__goat__pat = "goatron",
                sms__shader__goat__slen = true,
                sms__shader__goat__tp = 0.50,
                sms__shader__goat__vdiv = 0.50,

                // Mega Drive
                md__cdbios = "us_scd1_9210.bin",
                md__correct_aspect = true,                                  // placed
                md__input__auto = true,                                     // placed
                md__input__mouse_sensitivity = 1,                           // placed
                md__input__multitap = "none",                               // placed
                md__input__port1 = "gamepad",                               // placed
                md__input__port2 = "gamepad",                               // placed
                md__input__port3 = "gamepad",                               // placed
                md__input__port4 = "gamepad",                               // placed
                md__input__port5 = "gamepad",                               // placed
                md__input__port6 = "gamepad",                               // placed
                md__input__port7 = "gamepad",                               // placed
                md__input__port8 = "gamepad",                               // placed
                md__region = "game",                                        // placed                
                md__reported_region = "same",                               // placed 
                md__debugger__disfontsize = "5x7",
                md__debugger__memcharenc = "shift_jis",

                md__enable = true,
                md__forcemono = false,                                // control placed
                md__shader = "none",                               // control placed
                md__scanlines = 0,                                    // control placed
                md__special = "none",                                 // control placed
                md__stretch = "aspect_mult2",                         // control placed
                md__tblur = false,                                    // control placed
                md__tblur__accum = false,                             // control placed
                md__tblur__accum__amount = 50,                        // control placed
                md__videoip = "1",                                    // control placed
                md__xres = 0,                                         // control placed
                md__xscale = 3,                                       // control placed
                md__xscalefs = 1,                                     // control placed
                md__yres = 0,                                         // control placed
                md__yscale = 3,                                       // control placed
                md__yscalefs = 1,                                     // control placed

                md__shader__goat__fprog = false,
                md__shader__goat__hdiv = 0.50,
                md__shader__goat__pat = "goatron",
                md__shader__goat__slen = true,
                md__shader__goat__tp = 0.50,
                md__shader__goat__vdiv = 0.50,

                // saturn
                ss__bios_jp = "sega_101.bin",
                ss__bios_na_eu = "mpr-17933.bin",
                ss__bios_sanity = true,                                     // placed
                ss__cart = "auto",                                          // placed
                ss__cart__kof95_path = "mpr-18811-mx.ic1",
                ss__cart__ultraman_path = "mpr-19367-mx.ic1",
                ss__cd_sanity = true,                                       // placed
                ss__input__mouse_sensitivity = 0.5,                         // placed
                ss__input__port1 = "gamepad",                               // placed
                ss__input__port1__gun_chairs = "0xFF0000",
                ss__input__port2 = "gamepad",                               // placed
                ss__input__port2__gun_chairs = "0x00FF00",
                ss__input__port3 = "gamepad",                               // placed
                ss__input__port3__gun_chairs = "0xFF00FF",
                ss__input__port4 = "gamepad",                               // placed
                ss__input__port4__gun_chairs = "0xFF8000",
                ss__input__port5 = "gamepad",                               // placed
                ss__input__port5__gun_chairs = "0xFFFF00",
                ss__input__port6 = "gamepad",                               // placed
                ss__input__port6__gun_chairs = "0x00FFFF",
                ss__input__port7 = "gamepad",                               // placed
                ss__input__port7__gun_chairs = "0x0080FF",
                ss__input__port8 = "gamepad",                               // placed
                ss__input__port8__gun_chairs = "0x8000FF",
                ss__input__port9 = "gamepad",                               // placed
                ss__input__port9__gun_chairs = "0xFF80FF",
                ss__input__port10 = "gamepad",                              // placed
                ss__input__port10__gun_chairs = "0x00FF80",
                ss__input__port11 = "gamepad",                              // placed
                ss__input__port11__gun_chairs = "0x8080FF",
                ss__input__port12 = "gamepad",                              // placed
                ss__input__port12__gun_chairs = "0xFF8080",
                ss__midsync = false,                                        // placed
                ss__region_autodetect = true,                               // placed
                ss__region_default = "jp",                                  // placed
                ss__scsp__resamp_quality = 4,                               // placed
                ss__slend = 239,                                            // placed
                ss__slendp = 255,                                           // placed
                ss__slstart = 0,                                            // placed
                ss__slstartp = 0,                                           // placed
                ss__smpc__autortc = true,                                   // placed
                ss__smpc__autortc__lang = "english",                        // placed
                ss__debugger__disfontsize = "5x7",                           // placed
                ss__debugger__memcharenc = "SJIS",                           // placed

                ss__enable = true,
                ss__forcemono = false,                                // control placed
                ss__shader = "none",                               // control placed
                ss__scanlines = 0,                                    // control placed
                ss__special = "none",                                 // control placed
                ss__stretch = "aspect_mult2",                         // control placed
                ss__tblur = false,                                    // control placed
                ss__tblur__accum = false,                             // control placed
                ss__tblur__accum__amount = 50,                        // control placed
                ss__videoip = "1",                                    // control placed
                ss__xres = 0,                                         // control placed
                ss__xscale = 3,                                       // control placed
                ss__xscalefs = 1,                                     // control placed
                ss__yres = 0,                                         // control placed
                ss__yscale = 3,                                       // control placed
                ss__yscalefs = 1,                                     // control placed

                ss__correct_aspect = true,                              // control placed
                ss__h_blend = false,                                    // control placed
                ss__h_overscan = true,                                  // control placed

                ss__shader__goat__fprog = false,
                ss__shader__goat__hdiv = 0.50,
                ss__shader__goat__pat = "goatron",
                ss__shader__goat__slen = true,
                ss__shader__goat__tp = 0.50,
                ss__shader__goat__vdiv = 0.50,

                ss__input__sport1__multitap = false,
                ss__input__sport2__multitap = false,

                /* moved into controls section
                ss__input__port10__3dpad__mode__defpos = "digital",
                ss__input__port11__3dpad__mode__defpos = "digital",
                ss__input__port12__3dpad__mode__defpos = "digital",
                ss__input__port1__3dpad__mode__defpos = "digital",
                ss__input__port2__3dpad__mode__defpos = "digital",
                ss__input__port3__3dpad__mode__defpos = "digital",
                ss__input__port4__3dpad__mode__defpos = "digital",
                ss__input__port5__3dpad__mode__defpos = "digital",
                ss__input__port6__3dpad__mode__defpos = "digital",
                ss__input__port7__3dpad__mode__defpos = "digital",
                ss__input__port8__3dpad__mode__defpos = "digital",
                ss__input__port9__3dpad__mode__defpos = "digital",
                */


                // playstation
                psx__bios_eu = "scph5502.bin",
                psx__bios_jp = "scph5500.bin",
                psx__bios_na = "scph5501.bin",
                psx__bios_sanity = true,                                    // placed
                psx__cd_sanity = true,                                      // placed
                psx__dbg_level = 0,                                         // placed
                psx__h_overscan = true,                                     // placed
                psx__input__analog_mode_ct = false,                         // placed
                psx__input__mouse_sensitivity = 1,                          // placed
                psx__input__port1 = "gamepad",
                //psx__input__port1__analogjoy__axis_scale = 1,               // placed
                //psx__input__port1__dualanalog__axis_scale = 1,          // placed
                //psx__input__port1__dualshock__axis_scale = 1,   // placed
                psx__input__port1__gun_chairs = "0xFF0000",     // placed
                psx__input__port1__memcard = true,              // placed
                psx__input__port2 = "gamepad",  // placed
                //psx__input__port2__analogjoy__axis_scale = 1,   // placed
                //psx__input__port2__dualanalog__axis_scale = 1,  // placed
                //psx__input__port2__dualshock__axis_scale = 1,   // placed
                psx__input__port2__gun_chairs = "0xFF0000", // placed
                psx__input__port2__memcard = true,  // placed
                psx__input__port3 = "gamepad",  // placed
                //psx__input__port3__analogjoy__axis_scale = 1,   // placed
                //psx__input__port3__dualanalog__axis_scale = 1,  // placed
                //psx__input__port3__dualshock__axis_scale = 1,   // placed
                psx__input__port3__gun_chairs = "0xFF0000", // placed
                psx__input__port3__memcard = true,  // placed
                psx__input__port4 = "gamepad",  // placed
                //psx__input__port4__analogjoy__axis_scale = 1,   // placed
                //psx__input__port4__dualanalog__axis_scale = 1,  // placed
                //psx__input__port4__dualshock__axis_scale = 1,// placed
                psx__input__port4__gun_chairs = "0xFF0000", // placed
                psx__input__port4__memcard = true,  // placed
                psx__input__port5 = "gamepad",  // placed
                //psx__input__port5__analogjoy__axis_scale = 1,   // placed
                //psx__input__port5__dualanalog__axis_scale = 1,  // placed
                //psx__input__port5__dualshock__axis_scale = 1,   // placed
                psx__input__port5__gun_chairs = "0xFF0000", // placed
                psx__input__port5__memcard = true,  // placed
                psx__input__port6 = "gamepad",  // placed
                //psx__input__port6__analogjoy__axis_scale = 1,   // placed
                //psx__input__port6__dualanalog__axis_scale = 1,  // placed
                //psx__input__port6__dualshock__axis_scale = 1,   // placed
                psx__input__port6__gun_chairs = "0xFF0000", // placed
                psx__input__port6__memcard = true,  // placed
                psx__input__port7 = "gamepad",  // placed
                //psx__input__port7__analogjoy__axis_scale = 1,   // placed
                //psx__input__port7__dualanalog__axis_scale = 1,  // placed
                //psx__input__port7__dualshock__axis_scale = 1,   // placed
                psx__input__port7__gun_chairs = "0xFF0000", // placed
                psx__input__port7__memcard = true,  // placed
                psx__input__port8 = "gamepad",  // placed
                //psx__input__port8__analogjoy__axis_scale = 1,   // placed
                //psx__input__port8__dualanalog__axis_scale = 1,  // placed
                //psx__input__port8__dualshock__axis_scale = 1,   // placed
                psx__input__port8__gun_chairs = "0xFF0000",         // placed
                psx__input__port8__memcard = true,                  // placed
                psx__input__pport1__multitap = false,               // placed
                psx__input__pport2__multitap = false,               // placed
                psx__region_autodetect = true,                      // placed
                psx__region_default = "jp",                         // placed
                psx__slend = 239,                                   // placed
                psx__slendp = 287,                                  // placed
                psx__slstart = 0,                                   // placed
                psx__slstartp = 0,                                  // placed
                psx__spu__resamp_quality = 5,                       // placed
                psx__debugger__disfontsize = "5x7",                  // placed
                psx__debugger__memcharenc = "shift_jis",             // placed

                psx__enable = true,
                psx__forcemono = false,                                // control placed
                psx__shader = "none",                               // control placed
                psx__scanlines = 0,                                    // control placed
                psx__special = "none",                                 // control placed
                psx__stretch = "aspect_mult2",                         // control placed
                psx__tblur = false,                                    // control placed
                psx__tblur__accum = false,                             // control placed
                psx__tblur__accum__amount = 50,                        // control placed
                psx__videoip = "1",                                    // control placed
                psx__xres = 0,                                         // control placed
                psx__xscale = 3,                                       // control placed
                psx__xscalefs = 1,                                     // control placed
                psx__yres = 0,                                         // control placed
                psx__yscale = 3,                                       // control placed
                psx__yscalefs = 1,                                     // control placed

                psx__input__analog_mode_ct__compare = "0x0F09",

                psx__shader__goat__fprog = false,
                psx__shader__goat__hdiv = 0.50,
                psx__shader__goat__pat = "goatron",
                psx__shader__goat__slen = true,
                psx__shader__goat__tp = 0.50,
                psx__shader__goat__vdiv = 0.50,

                psx_shared_memcards = false,

                // snes faust
                snes_faust__correct_aspect = true,

                snes_faust__input__sport1__multitap = false,
                snes_faust__input__sport2__multitap = false,
                snes_faust__input__port1 = "gamepad",               // placed
                snes_faust__input__port2 = "gamepad",               // placed
                snes_faust__input__port3 = "gamepad",               // placed
                snes_faust__input__port4 = "gamepad",               // placed
                snes_faust__input__port5 = "gamepad",               // placed
                snes_faust__input__port6 = "gamepad",               // placed
                snes_faust__input__port7 = "gamepad",               // placed
                snes_faust__input__port8 = "gamepad",               // placed
                snes_faust__resamp_quality = 3,                     // placed
                snes_faust__resamp_rate_error = 0.000035,           // placed
                snes_faust__spex = false,                           // placed
                snes_faust__spex__sound = true,                     // placed

                snes_faust__enable = true,
                snes_faust__forcemono = false,                                // control placed
                snes_faust__shader = "none",                               // control placed
                snes_faust__scanlines = 0,                                    // control placed
                snes_faust__special = "none",                                 // control placed
                snes_faust__stretch = "aspect_mult2",                         // control placed
                snes_faust__tblur = false,                                    // control placed
                snes_faust__tblur__accum = false,                             // control placed
                snes_faust__tblur__accum__amount = 50,                        // control placed
                snes_faust__videoip = "1",                                    // control placed
                snes_faust__xres = 0,                                         // control placed
                snes_faust__xscale = 3,                                       // control placed
                snes_faust__xscalefs = 1,                                     // control placed
                snes_faust__yres = 0,                                         // control placed
                snes_faust__yscale = 3,                                       // control placed
                snes_faust__yscalefs = 1,                                     // control placed

                snes_faust__shader__goat__fprog = false,
                snes_faust__shader__goat__hdiv = 0.50,
                snes_faust__shader__goat__pat = "goatron",
                snes_faust__shader__goat__slen = true,
                snes_faust__shader__goat__tp = 0.50,
                snes_faust__shader__goat__vdiv = 0.50,

                // snes
                snes__apu__resamp_quality = 5,                      // placed
                snes__correct_aspect = false,                       // placed     
                      
                snes__input__port1__multitap = false,               // placed
                snes__input__port2__multitap = false,               // placed
                snes__input__port1 = "gamepad",                     // placed
                snes__input__port2 = "gamepad",                     // placed
                /*     
                snes__input__port3 = "gamepad",                     // placed
                snes__input__port4 = "gamepad",                     // placed
                snes__input__port5 = "gamepad",                     // placed
                snes__input__port6 = "gamepad",                     // placed
                snes__input__port7 = "gamepad",                     // placed
                snes__input__port8 = "gamepad",
                */
                snes__mouse_sensitivity = 0.5,                      // placed

                snes__enable = true,
                snes__forcemono = false,                                // control placed
                snes__shader = "none",                               // control placed
                snes__scanlines = 0,                                    // control placed
                snes__special = "none",                                 // control placed
                snes__stretch = "aspect_mult2",                         // control placed
                snes__tblur = false,                                    // control placed
                snes__tblur__accum = false,                             // control placed
                snes__tblur__accum__amount = 50,                        // control placed
                snes__videoip = "0",                                    // control placed
                snes__xres = 0,                                         // control placed
                snes__xscale = 4,                                       // control placed
                snes__xscalefs = 1,                                     // control placed
                snes__yres = 0,                                         // control placed
                snes__yscale = 4,                                       // control placed
                snes__yscalefs = 1,                                     // control placed

                snes__shader__goat__fprog = false,
                snes__shader__goat__hdiv = 0.50,
                snes__shader__goat__pat = "goatron",
                snes__shader__goat__slen = true,
                snes__shader__goat__tp = 0.50,
                snes__shader__goat__vdiv = 0.50,

                snes__h_blend = false,



                // virtual boy
                vb__3dmode = "anaglyph",                            // placed
                vb__3dreverse = false,                              // placed
                vb__allow_draw_skip = false,                        // placed
                vb__anaglyph__lcolor = "0xffba00",                  // placed
                vb__anaglyph__preset = "red_blue",                   // placed
                vb__anaglyph__rcolor = "0x00baff",                  // placed
                vb__cpu_emulation = "fast",                         // placed
                vb__default_color = "0xF0F0F0",                     // placed
                vb__disable_parallax = false,                       // placed
                vb__input__instant_read_hack = true,                // placed
                vb__instant_display_hack = false,                   // placed
                vb__liprescale = 2,                                 // placed
                vb__sidebyside__separation = 0,                     // placed
                vb__debugger__disfontsize = "5x7",                   // placed
                vb__debugger__memcharenc = "shift_jis",              // placed

                vb__enable = true,
                vb__forcemono = false,                                // control placed
                vb__shader = "none",                               // control placed
                vb__scanlines = 0,                                    // control placed
                vb__special = "none",                                 // control placed
                vb__stretch = "aspect_mult2",                         // control placed
                vb__tblur = false,                                    // control placed
                vb__tblur__accum = false,                             // control placed
                vb__tblur__accum__amount = 50,                        // control placed
                vb__videoip = "0",                                    // control placed
                vb__xres = 0,                                         // control placed
                vb__xscale = 2,                                       // control placed
                vb__xscalefs = 1,                                     // control placed
                vb__yres = 0,                                         // control placed
                vb__yscale = 2,                                       // control placed
                vb__yscalefs = 1,                                     // control placed

                vb__ledonscale = 1.75,

                vb__shader__goat__fprog = false,
                vb__shader__goat__hdiv = 0.50,
                vb__shader__goat__pat = "goatron",
                vb__shader__goat__slen = true,
                vb__shader__goat__tp = 0.50,
                vb__shader__goat__vdiv = 0.50,

                // wonderswan
                wswan__bday = 23,                                   // placed
                wswan__blood = "o",                                 // placed
                wswan__bmonth = 6,                                  // placed
                wswan__byear = 1989,                                // placed
                wswan__language = "english",
                wswan__name = "Mednafen",                           // placed
                //wswan__rotateinput = false,                         // placed
                wswan__sex = "female",                              // placed

                wswan__debugger__disfontsize = "5x7",
                wswan__debugger__memcharenc = "shift_jis",

                wswan__enable = true,
                wswan__forcemono = false,                                // control placed
                wswan__shader = "none",                               // control placed
                wswan__scanlines = 0,                                    // control placed
                wswan__special = "none",                                 // control placed
                wswan__stretch = "aspect_mult2",                         // control placed
                wswan__tblur = false,                                    // control placed
                wswan__tblur__accum = false,                             // control placed
                wswan__tblur__accum__amount = 50,                        // control placed
                wswan__videoip = "0",                                    // control placed
                wswan__xres = 0,                                         // control placed
                wswan__xscale = 4,                                       // control placed
                wswan__xscalefs = 1,                                     // control placed
                wswan__yres = 0,                                         // control placed
                wswan__yscale = 4,                                       // control placed
                wswan__yscalefs = 1,                                     // control placed

                wswan__shader__goat__fprog = false,
                wswan__shader__goat__hdiv = 0.50,
                wswan__shader__goat__pat = "goatron",
                wswan__shader__goat__slen = true,
                wswan__shader__goat__tp = 0.50,
                wswan__shader__goat__vdiv = 0.50,

                wswan__input__builtin = "gamepad",


            };

            return cfbs;
        }

        public static void SaveToDatabase(List<ConfigBaseSettings> Configs)
        {
            using (var db = new MyDbContext())
            {
                // get current database context
                var current = db.ConfigBaseSettings.AsNoTracking().ToList();

                List<ConfigBaseSettings> toAdd = new List<ConfigBaseSettings>();
                List<ConfigBaseSettings> toUpdate = new List<ConfigBaseSettings>();

                // iterate through the games list and separete out games to be added and games to be updated
                foreach (var g in Configs)
                {
                    ConfigBaseSettings t = (from a in current
                                     where a.ConfigId == g.ConfigId
                                     select a).SingleOrDefault();
                    if (t == null) { toAdd.Add(g); }
                    else { toUpdate.Add(g); }
                }
                db.ConfigBaseSettings.UpdateRange(toUpdate);
                db.ConfigBaseSettings.AddRange(toAdd);
                db.SaveChanges();
            }
        }

        public static void ResetToDefault(string btnName)
        {
            string rbName = btnName.ToLower();
            // get system code from name
            string code = rbName.Replace("btnconfig", "").Trim();
            //MessageBoxResult result = MessageBox.Show(code);

            int baseId = 2000000000;
            int sysId = 0;
            if (code == "base")
            {
                // do nothing
            }
            else
            {
                sysId = GetSystemIdFromSystemCode(code);                
            }

            int configId = baseId + sysId;

            // get defaults
            ConfigBaseSettings defaults = ConfigBaseSettings.GetConfigDefaults();
            defaults.ConfigId = configId;
            defaults.systemIdent = sysId;
            defaults.UpdatedTime = DateTime.Now;

            // Get current config
            ConfigBaseSettings config = ConfigBaseSettings.GetConfig(configId);
            var conf = new ConfigBaseSettings();
            conf = config;


            if (config.isEnabled == true)
            {
                defaults.isEnabled = true;
            }
            else
            {
                defaults.isEnabled = false;
            }


            // set defaults for this config
            using (var cfDef = new MyDbContext())
            {
                cfDef.Entry(defaults).State = Microsoft.Data.Entity.EntityState.Modified;
                cfDef.SaveChanges();
            }
        }

        public static int GetConfigIdFromButtonName(string btnName)
        {
            string rbName = btnName.ToLower();
            // get system code from name
            string code = rbName.Replace("btnconfig", "").Trim();
            int baseId = 2000000000;
            int sysId = 0;
            if (code == "base")
            {
                // do nothing
            }
            else
            {
                sysId = GetSystemIdFromSystemCode(code);
            }
            //MessageBoxResult result = MessageBox.Show(code);

            int configId = baseId + sysId;
            return configId;
        }

        public static string GetConfigFileNameFromConfigId(int configId)
        {
            return "";
        }

        public static void EnableConfigToggle(string btnName)
        {
            string rbName = btnName.ToLower();
            // get system code from name
            string code = rbName.Replace("btnconfig", "").Trim();
            //MessageBoxResult result = MessageBox.Show(code);

            int baseId = 2000000000;
            int sysId = 0;
            if (code == "base")
            {
                // do nothing
            }
            else
            {
                sysId = GetSystemIdFromSystemCode(code);
            }

            int configId = baseId + sysId;

            // Get current config
            ConfigBaseSettings config = ConfigBaseSettings.GetConfig(configId);
            var conf = new ConfigBaseSettings();
            conf = config;


            if (config.isEnabled == true)
            {
                conf.isEnabled = false;
            }
            else
            {
                conf.isEnabled = true;
            }
            // set defaults for this config
            using (var cfDef = new MyDbContext())
            {
                cfDef.Entry(config).State = Microsoft.Data.Entity.EntityState.Modified;
                cfDef.SaveChanges();
                cfDef.Dispose();
            }
            //SetConfig(config);


        }

        public static ConfigBaseSettings GetConfig(int ConfigId)
        {
            using (var context = new MyDbContext())
            {
                var cData = context.ConfigBaseSettings.AsNoTracking().ToList();
                ConfigBaseSettings c = (from a in cData
                                        where a.ConfigId == ConfigId
                                        select a).ToList().SingleOrDefault();
                if (c == null)
                    return null;
                context.Dispose();
                return c;
            }
        }

        public static void SetConfig(ConfigBaseSettings Config)
        {
            using (var cfDef = new MyDbContext())
            {

                cfDef.Entry(Config).State = Microsoft.Data.Entity.EntityState.Modified;
                cfDef.SaveChanges();
            }
        }

        public static bool IsConfigEnabled(int systemId)
        {
            int baseId = 2000000000;
            int id = baseId + systemId;

            using (var context = new MyDbContext())
            {
                var c = (from a in context.ConfigBaseSettings
                        where a.ConfigId == id
                        select a).SingleOrDefault();

                if (c.isEnabled == true && c.isEnabled != null)
                    return true;
                else
                    return false;                
            }
        }
        
        public static void SetButtonState(RadioButton rb)
        {
            string rbName = rb.Name.ToLower();
            // get system code from name
            string code = rbName.Replace("btnconfig", "").Trim();
            //MessageBoxResult result = MessageBox.Show(code);

            if (code == "base")
            {
                rb.IsEnabled = true;
            }
            else
            {
                int systemId = GetSystemIdFromSystemCode(code);

                if (IsConfigEnabled(systemId) == true)
                {
                    rb.IsEnabled = true;
                }
                else
                {
                    rb.IsEnabled = true;
                }
            }
            
        }

        public static int GetSystemIdFromSystemCode(string systemCode)
        {
            GSystem gs = new GSystem(systemCode);
            return gs.systemId;
        }

        public static string ConvertControlNameToConfigName(string controlName)
        {
            return controlName.Replace("cfg_", "");
        }

        // populate settings - bios path controls
        public static void LoadBiosPathValues(StackPanel wp)
        {
            // get a class object with all child controls
            UIHandler ui = UIHandler.GetChildren(wp);

            // get all config settings for base config
            ConfigBaseSettings settings = GetConfig(2000000000);

            SetControlValues(ui, settings, 1);
        }

        // save settings - mednafen bios controls
        public static void SaveBiosPathValues(StackPanel wp)
        {
            // get a class object with all child controls
            UIHandler ui = UIHandler.GetChildren(wp);

            // get all config settings for base config
            //ConfigBaseSettings settings = GetConfig(2000000000);

            // get ALL config settings (as we are saving these to all configs)
            List<ConfigBaseSettings> AllSettings = new List<ConfigBaseSettings>();
            using (var context = new MyDbContext())
            {
                List<ConfigBaseSettings> aset = (from d in context.ConfigBaseSettings
                                                 select d).ToList();
                AllSettings.AddRange(aset);
            }

            // iterate through each config and set all the settings for each config
            foreach (ConfigBaseSettings settings in AllSettings)
            {
                SetControlValues(ui, settings, 2);
            }
        }

        public static void SaveBiosPaths()
        {
            MainWindow mw = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

            // get all the path values
            string gba = ((TextBox)mw.FindName("cfg_gba__bios")).Text;
            string pcege = ((TextBox)mw.FindName("cfg_pce__gecdbios")).Text;
            string pcecd = ((TextBox)mw.FindName("cfg_pce__cdbios")).Text;
            string pcefastcd = ((TextBox)mw.FindName("cfg_pce_fast__cdbios")).Text;
            string pcfx = ((TextBox)mw.FindName("cfg_pcfx__bios")).Text;
            string mdcd = ((TextBox)mw.FindName("cfg_md__cdbios")).Text;
            string nesgg = ((TextBox)mw.FindName("cfg_nes__ggrom")).Text;
            string ssjp = ((TextBox)mw.FindName("cfg_ss__bios_jp")).Text;
            string ssnaeu = ((TextBox)mw.FindName("cfg_ss__bios_na_eu")).Text;
            string psxeu = ((TextBox)mw.FindName("cfg_psx__bios_eu")).Text;
            string psxjp = ((TextBox)mw.FindName("cfg_psx__bios_jp")).Text;
            string psxna = ((TextBox)mw.FindName("cfg_psx__bios_na")).Text;

            using (var db = new MyDbContext())
            {
                // get all configs
                var configs = from a in db.ConfigBaseSettings
                              select a;
                foreach (var c in configs)
                {
                    // update each config file
                    c.gba__bios = gba;
                    c.pce__gecdbios = pcege;
                    c.pce__cdbios = pcecd;
                    c.pce_fast__cdbios = pcefastcd;
                    c.pcfx__bios = pcfx;
                    c.md__cdbios = mdcd;
                    c.nes__ggrom = nesgg;
                    c.ss__bios_jp = ssjp;
                    c.ss__bios_na_eu = ssnaeu;
                    c.psx__bios_eu = psxeu;
                    c.psx__bios_jp = psxjp;
                    c.psx__bios_na = psxna;
                    //db.SaveChanges();
                }

                // save changes
                db.SaveChanges();
            }
        }

        // populate settings - mednafen paths controls
        public static void LoadMednafenPathValues(StackPanel wp)
        {
            // get a class object with all child controls
            UIHandler ui = UIHandler.GetChildren(wp);

            // get all config settings for base config
            ConfigBaseSettings settings = GetConfig(2000000000);

            SetControlValues(ui, settings, 1);
        }

        // save settings - mednafen paths controls
        public static void SaveMednafenPathValues(StackPanel wp)
        {
            // get a class object with all child controls
            UIHandler ui = UIHandler.GetChildren(wp);

            // get all config settings for base config
            //ConfigBaseSettings settings = GetConfig(2000000000);

            // get ALL config settings (as we are saving these to all configs)
            List<ConfigBaseSettings> AllSettings = new List<ConfigBaseSettings>();
            using (var context = new MyDbContext())
            {
                List<ConfigBaseSettings> aset = (from d in context.ConfigBaseSettings
                                                        select d).ToList();
                AllSettings.AddRange(aset);
            }

            // iterate through each config and set all the settings for each config
            foreach (ConfigBaseSettings settings in AllSettings)
            {
                SetControlValues(ui, settings, 2);
            }       
        }

        public static void SaveMednafenPaths()
        {
            MainWindow mw = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

            // get all the path values
            string cheats = ((TextBox)mw.FindName("cfg_filesys__path_cheat")).Text;
            string firmware = ((TextBox)mw.FindName("cfg_filesys__path_firmware")).Text;
            string movies = ((TextBox)mw.FindName("cfg_filesys__path_movie")).Text;
            string palettes = ((TextBox)mw.FindName("cfg_filesys__path_palette")).Text;
            string pgc = ((TextBox)mw.FindName("cfg_filesys__path_pgconfig")).Text;
            string saves = ((TextBox)mw.FindName("cfg_filesys__path_sav")).Text;
            string savebackup = ((TextBox)mw.FindName("cfg_filesys__path_savbackup")).Text;
            string snapshots = ((TextBox)mw.FindName("cfg_filesys__path_snap")).Text;
            string savestates = ((TextBox)mw.FindName("cfg_filesys__path_state")).Text;

            using (var db = new MyDbContext())
            {
                // get all configs
                var configs = from a in db.ConfigBaseSettings
                              select a;
                foreach (var c in configs)
                {
                    // update each config file
                    c.filesys__path_cheat = cheats;
                    c.filesys__path_firmware = firmware;
                    c.filesys__path_movie = movies;
                    c.filesys__path_palette = palettes;
                    c.filesys__path_pgconfig = pgc;
                    c.filesys__path_sav = saves;
                    c.filesys__path_savbackup = savebackup;
                    c.filesys__path_snap = snapshots;
                    c.filesys__path_state = savestates;
                }

                // save changes
                db.SaveChanges();
            }
        }

        public static void SetControlValues(UIHandler ui, ConfigBaseSettings settings, int LoadOrSave)
        {
            if (LoadOrSave == 1)
            {
                // 1 = load settings
                // Iterate through all controls and set correct values
                // Buttons
                foreach (Button control in ui.Buttons)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_"))
                    {
                        // checkbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");                    
                    }
                    else
                    {
                        // check that the control is actually a config control
                        if (propName.Contains("_"))
                        {
                            // get the property value using reflection
                            var value = settings.GetType().GetProperty(propName).GetValue(settings, null);
                            string v = value.ToString();

                            // update wpf control
                            control.Content = v;
                        }
                        else
                        {
                            
                        }

                        
                    }
                }

                // RadioButtons

                // Labels

                // CheckBoxes
                foreach (CheckBox control in ui.CheckBoxes)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_") || control.Name.Contains("comboPsx"))
                    {
                        // checkbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");                    
                    }
                    else
                    {
                        // get the property value using reflection
                        var value = settings.GetType().GetProperty(propName).GetValue(settings, null);
                        bool v = Convert.ToBoolean(value.ToString());

                        // update wpf control
                        control.IsChecked = v;
                    }
                }

                // TextBoxes
                foreach (TextBox control in ui.TextBoxes)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_"))
                    {
                        // textbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");                    
                    }
                    else
                    {
                        // get the property value using reflection
                        var value = settings.GetType().GetProperty(propName).GetValue(settings, null);
                        string v = value.ToString();

                        // update wpf control
                        control.Text = v;
                    }
                }

                // Sliders
                foreach (Slider control in ui.Sliders)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_") || control.Name.Contains("ALPHA"))
                    {
                        // checkbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");
                    }
                    else
                    {
                        // get the property value using reflection
                        var value = settings.GetType().GetProperty(propName).GetValue(settings, null);
                        //bool v = Convert.ToBoolean(value.ToString());
                        double v = Convert.ToDouble(value.ToString(), System.Globalization.CultureInfo.InvariantCulture);

                        // update wpf control
                        control.Value = v;
                    }
                }

                // Comboxes
                foreach (ComboBox control in ui.ComboBoxes)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_"))
                    {
                        // checkbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");
                    }
                    else
                    {
                        // get the property value using reflection
                        var value = settings.GetType().GetProperty(propName).GetValue(settings, null);
                        //bool v = Convert.ToBoolean(value.ToString());
                        string v = value.ToString();

                        // update wpf control
                        control.SelectedValue = v;
                    }
                }

                // NumericUpDowns
                foreach (NumericUpDown control in ui.NumericUpDowns)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_"))
                    {
                        // checkbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");
                    }
                    else
                    {
                        // get the property value using reflection
                        var value = settings.GetType().GetProperty(propName).GetValue(settings, null);
                        //bool v = Convert.ToBoolean(value.ToString());
                        double v = Convert.ToDouble(value.ToString(), System.Globalization.CultureInfo.InvariantCulture);

                        // update wpf control
                        control.Value = v;
                    }
                }

                // ColorPickers
                foreach (ColorPicker control in ui.Colorpickers)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_"))
                    {
                        // checkbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");
                    }
                    else
                    {
                        var value = settings.GetType().GetProperty(propName).GetValue(settings, null);
                        string v = value.ToString();

                        // update wpf control

                        string n = string.Empty;

                        // strip leading 0x
                        if (v.StartsWith("0x"))
                            n = v.Replace("0x", "");
                        else
                            n = v;

                        /*
                        // handle AARRGGBB values (eg FPS colors)
                        if (n.Length == 8)
                        {
                            // this is AARRGGBB - we need to take the alpha channel value from the first byte
                            // and update the matching alpha channel slider

                            // first find the matching alpha channel control (currently only valid for FPS colors)
                            string ctrlName = control.Name;
                            string lookupName = ctrlName.Replace("cfg_fps__", "cfg_ALPHAfps__");
                            Slider alphaSlider = ui.Sliders.Where(a => a.Name == lookupName).FirstOrDefault();

                            // split the hex value into AA and RRGGBB
                            string AA = n.Substring(0, 2);
                            string RRBBGG = n.Substring(2, 6);

                            // update the colorpicker
                            control.SelectedColor = (Color)System.Windows.Media.ColorConverter.ConvertFromString("#" + RRBBGG);

                            // update the alpha slider
                            int aVal = int.Parse(AA, System.Globalization.NumberStyles.HexNumber);
                            double aVa = (double)aVal;
                            //alphaSlider.Value = aVa;
                        }
                        else
                        {
                            // this is RRGGBB - update the colorpicker directly with the value
                            control.SelectedColor = (Color)System.Windows.Media.ColorConverter.ConvertFromString("#" + n);
                        }
                        */

                        control.SelectedColor = (Color)System.Windows.Media.ColorConverter.ConvertFromString("#" + n);
                    }
                }

            }
            if (LoadOrSave == 2)
            {
                // 2 = save settings
                // Iterate through all controls and set correct values
                // Buttons
                foreach (Button control in ui.Buttons)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_"))
                    {
                        // checkbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");                    
                    }
                    else
                    {
                        // check that the control is actually a config control
                        if (propName.Contains("_"))
                        {
                            // get the control value
                            string v = control.Content.ToString();
                            // update settings object with value
                            PropertyInfo propInfo = settings.GetType().GetProperty(propName);
                            propInfo.SetValue(settings, v, null);
                        }
                    }
                }

                // RadioButtons

                // Labels

                // CheckBoxes
                foreach (CheckBox control in ui.CheckBoxes)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_") || control.Name.Contains("comboPsx"))
                    {
                        // checkbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");                    
                    }
                    else
                    {
                        // get the control value
                        bool? v = control.IsChecked.Value;
                        // update settings object with value
                        PropertyInfo propInfo = settings.GetType().GetProperty(propName);
                        propInfo.SetValue(settings, v, null);
                    }
                }

                // TextBoxes
                foreach (TextBox control in ui.TextBoxes)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_"))
                    {
                        // textbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");                    
                    }
                    else
                    {
                        // get the control value
                        string v = control.Text;
                        // update settings object with value
                        PropertyInfo propInfo = settings.GetType().GetProperty(propName);
                        propInfo.SetValue(settings, v, null);
                    }
                }

                // Sliders
                foreach (Slider control in ui.Sliders)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_") || control.Name.Contains("ALPHA"))
                    {
                        // checkbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");
                    }
                    else
                    {
                        // get the control value
                        double? v = control.Value;
                        // update settings object with value
                        PropertyInfo propInfo = settings.GetType().GetProperty(propName);

                        if (propInfo.PropertyType.ToString().Contains("[System.Double]"))
                        {
                            // double is required
                            propInfo.SetValue(settings, v, null);
                            //MessageBoxResult aresult = MessageBox.Show(propInfo.PropertyType.ToString());
                        }
                        if (propInfo.PropertyType.ToString().Contains("[System.Int32]"))
                        {
                            // int32 is required
                            //MessageBoxResult aresult = MessageBox.Show(propInfo.PropertyType.ToString());
                            propInfo.SetValue(settings, Convert.ToInt32(v), null);
                        }
                    }
                }

                // Comboxes
                foreach (ComboBox control in ui.ComboBoxes)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_") || ((ComboBoxItem)control.SelectedItem) == null)
                    {
                        // checkbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");
                    }
                    else
                    {
                        // get the control value
                        //string v = control.SelectedValue.ToString();
                        string v = ((ComboBoxItem)control.SelectedItem).Tag.ToString();
                        //MessageBoxResult aresult = MessageBox.Show(propName + "   -   " + v);

                        // update settings object with string value - 


                        PropertyInfo propInfo = settings.GetType().GetProperty(propName);
                        //MessageBoxResult aresult = MessageBox.Show(propName + "   -   " + propInfo.ToString() + "   -   " + v);

                        if (propInfo.PropertyType.ToString().Contains("[System.Double]") || propInfo.PropertyType.ToString().Contains("[System.Int32]"))
                        {
                            if (propInfo.PropertyType.ToString().Contains("[System.Double]"))
                            {
                                // double is required
                                double? d = Convert.ToDouble(v, System.Globalization.CultureInfo.InvariantCulture);
                                propInfo.SetValue(settings, d, null);
                                //MessageBoxResult aresult = MessageBox.Show(propInfo.PropertyType.ToString());
                            }
                            if (propInfo.PropertyType.ToString().Contains("[System.Int32]"))
                            {
                                // int32 is required
                                int? i = Convert.ToInt32(v);
                                //MessageBoxResult aresult = MessageBox.Show(propInfo.PropertyType.ToString());
                                propInfo.SetValue(settings, i, null);
                            }
                        }
                        else
                        {
                            propInfo.SetValue(settings, v, null);
                        }



                    }
                }

                // NumericUpDowns
                foreach (NumericUpDown control in ui.NumericUpDowns)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_"))
                    {
                        // checkbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");
                    }
                    else
                    {
                        // get the control value
                        double? v = control.Value;
                        // update settings object with value
                        PropertyInfo propInfo = settings.GetType().GetProperty(propName);

                        if (propInfo.PropertyType.ToString().Contains("[System.Double]"))
                        {
                            // double is required
                            propInfo.SetValue(settings, v, null);
                            //MessageBoxResult aresult = MessageBox.Show(propInfo.PropertyType.ToString());
                        }
                        if (propInfo.PropertyType.ToString().Contains("[System.Int32]"))
                        {
                            // int32 is required
                            //MessageBoxResult aresult = MessageBox.Show(propInfo.PropertyType.ToString());
                            propInfo.SetValue(settings, Convert.ToInt32(v), null);
                        }
                    }
                }

                // Colorpickers
                foreach (ColorPicker control in ui.Colorpickers)
                {
                    // get config entry name from control name
                    string propName = ConvertControlNameToConfigName(control.Name);
                    //MessageBoxResult result = MessageBox.Show(propName);
                    // make sure name is not null
                    if (control.Name == null || control.Name.Trim() == "" || control.Name.Contains("Generic__") || control.Name.Contains("tb_"))
                    {
                        // textbox does not have a name set - skip
                        //MessageBoxResult aresult = MessageBox.Show(propName + " IS EMPTY!");                    
                    }
                    else
                    {
                        // get the control values
                        System.Windows.Media.Color color = control.SelectedColor.Value;
                        string hex = new ColorConverter().ConvertToString(color);

                        string v = string.Empty;

                        // we (at the moment) only want the alpha channel for the fps settings                        
                        if (control.Name.Contains("fps"))
                        {
                            // AARRGGBB
                            v = "0x" + hex.Replace("#", "").ToUpper().Substring(0, 8);
                        }
                        else
                        {
                            // RRGGBB
                            v = "0x" + hex.Replace("#", "").ToUpper().Substring(2, 6);
                        }
                        /*
                        if (hex.Length == 9)
                        {
                            v = "0x" + hex.Replace("#", "").ToUpper().Substring(0, 8);
                        }
                        else
                        {
                            v = "0x" + hex.Replace("#", "").ToUpper().Substring(2, 6);
                        }
                        */
                        
                        // update settings object with value
                        PropertyInfo propInfo = settings.GetType().GetProperty(propName);
                        propInfo.SetValue(settings, v, null);                        
                    }
                }

                // save config
                SetConfig(settings);
            }
            
        }

        

        // Populate config settings for specific System ID  -   WrapPanel as parent     
        public static void LoadControlValues(WrapPanel wp, int configId)
        {
            // get a class object with all child controls
            UIHandler ui = UIHandler.GetChildren(wp);

            // get all config settings for system
            ConfigBaseSettings settings = GetConfig(configId);

            SetControlValues(ui, settings, 1);           

        }

        // Save config settings for specific System ID  -   WrapPanel as parent     
        public static void SaveControlValues(WrapPanel wp, int configId)
        {
            // get a class object with all child controls
            UIHandler ui = UIHandler.GetChildren(wp);

            // get all config settings for system
            ConfigBaseSettings settings = GetConfig(configId);

            SetControlValues(ui, settings, 2);

            

        }

        public static T ChangeType<T>(object value)
        {
            Type conversionType = typeof(T);
            if (conversionType.IsGenericType &&
                conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null) { return default(T); }

                conversionType = Nullable.GetUnderlyingType(conversionType); ;
            }

            return (T)Convert.ChangeType(value, conversionType);
        }


    }
}
