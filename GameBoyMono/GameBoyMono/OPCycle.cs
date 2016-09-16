﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoyMono
{
    class OPCycle
    {
        public static byte[] cycleArray = new byte[] {
            04,12,08,08,04,04,08,04,20,08,08,08,04,04,08,04,
            04,12,08,08,04,04,08,04,12,08,08,08,04,04,08,04,
            08,12,08,08,04,04,08,04,08,08,08,08,04,04,08,04,
            08,12,08,08,12,12,12,04,08,08,08,08,04,04,08,04,
            04,04,04,04,04,04,08,04,04,04,04,04,04,04,08,04,
            04,04,04,04,04,04,08,04,04,04,04,04,04,04,08,04,
            04,04,04,04,04,04,08,04,04,04,04,04,04,04,08,04,
            08,08,08,08,08,08,04,08,04,04,04,04,04,04,08,04,
            04,04,04,04,04,04,08,04,04,04,04,04,04,04,08,04,
            04,04,04,04,04,04,08,04,04,04,04,04,04,04,08,04,
            04,04,04,04,04,04,08,04,04,04,04,04,04,04,08,04,
            04,04,04,04,04,04,08,04,04,04,04,04,04,04,08,04,
            08,12,12,16,12,16,08,16,08,16,12,00,12,24,08,16,
            08,12,12,00,12,16,08,16,08,16,12,00,12,00,08,16,
            12,12,08,00,00,16,08,16,16,04,16,00,00,00,08,16,
            12,12,08,04,00,16,08,16,12,08,16,04,00,00,08,16 };

        public static byte[] cycleCBArray = new byte[] {
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08,
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08,
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08,
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08,
            08,08,08,08,08,08,12,08,08,08,08,08,08,08,12,08,
            08,08,08,08,08,08,12,08,08,08,08,08,08,08,12,08,
            08,08,08,08,08,08,12,08,08,08,08,08,08,08,12,08,
            08,08,08,08,08,08,12,08,08,08,08,08,08,08,12,08,
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08,
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08,
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08,
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08,
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08,
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08,
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08,
            08,08,08,08,08,08,16,08,08,08,08,08,08,08,16,08 };
    }
}
