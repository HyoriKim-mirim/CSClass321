﻿using System;

namespace CSClass32
{
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        internal void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
} 