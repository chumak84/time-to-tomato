﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToTomato.Model.Interfaces
{
    public interface ISecondTicker
    {
        void Start();
        void Stop();
        event EventHandler Tick;
    }
}
