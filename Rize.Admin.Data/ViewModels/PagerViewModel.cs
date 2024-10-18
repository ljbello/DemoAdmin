﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rize.Admin.Data.ViewModels
{
    public class PagerViewModel
    {
        public PagerViewModel()
        {
            Numeric = true;
            Info = true;
            PreviousNext = true;
        }

        public bool Input { get; set; }

        public bool Numeric { get; set; }

        public bool Info { get; set; }

        public bool PreviousNext { get; set; }

        public bool Refresh { get; set; }

        public bool PageSizes { get; set; }
    }
}
