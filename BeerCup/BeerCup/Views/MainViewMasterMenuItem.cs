﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCup.Views
{

    public class MainViewMasterMenuItem
    {
        public MainViewMasterMenuItem()
        {
            TargetType = typeof(MainViewMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}