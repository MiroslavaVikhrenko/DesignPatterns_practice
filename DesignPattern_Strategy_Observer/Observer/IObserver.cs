﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Strategy_Observer.Observer
{
    public interface IObserver
    {
        void Update(double temperature, double area);
    }
}
