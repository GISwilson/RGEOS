﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RGeos.Carto
{
    public interface ISelection
    {
        List<Feature> SelectedFeatures { get; set; }
    }
}
