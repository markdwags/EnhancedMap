﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EnhancedMapServerNetCore.Network
{
    [Flags]
    public enum PROTOCOL
    {
        PROTOCOL_2 = 0x02,
        PROTOCOL_3 = 0x03,
    }
}
