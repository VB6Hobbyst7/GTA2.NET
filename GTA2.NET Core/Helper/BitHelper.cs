// GTA2.NET
// 
// File: BitHelper.cs
// Created: 29.01.2010
// 
// 
// Copyright (C) 2010-2013 Hiale
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software
// and associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute,
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software
// is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies
// or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR
// IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
// Grand Theft Auto (GTA) is a registred trademark of Rockstar Games.
using System;

namespace Hiale.GTA2NET.Core.Helper
{
    public static class BitHelper
    {
        public static bool CheckBit(int value, int bitOffset)
        {
            if (bitOffset < 0 || bitOffset >= sizeof(int) * 8)
                throw new ArgumentOutOfRangeException();
            //var bitValue = (int)Math.Pow(2, bitOffset);
            //return (value & bitValue) == bitValue;
            return (value & (1 << bitOffset)) == (1 << bitOffset);
        }

        public static ushort SetBit(ushort value, byte bitOffset, bool bitValue)
        {
            if (bitOffset >= sizeof(ushort) * 8)
                throw new ArgumentOutOfRangeException();
            if (bitValue)
                return (ushort) (value | (1 << bitOffset)); ////turn Bit on
            return (ushort)(value & ~(1 << bitOffset)); //turn Bit off
        }

    }
}
