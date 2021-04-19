﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_UML.Core.Serialize.InterfacesSerialize
{
    public interface IBase
    {
        List<DataCommon> Data { get; set; }
        Color Color { get; set; }
        float Width { get; set; }        
        float Size { get; set; }
    }
}