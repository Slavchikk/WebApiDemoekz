﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Media;


namespace WebApiDemoekz
{
    public partial class Tour
    {
        public SolidColorBrush TourColor
        {
            get
            {
                switch (IsActual)
                {
                    case true:
                        return Brushes.LightGreen;
                    case false:
                        return Brushes.LightPink;
                    default:
                        return Brushes.White;
                }
            }
        }
    }
}
