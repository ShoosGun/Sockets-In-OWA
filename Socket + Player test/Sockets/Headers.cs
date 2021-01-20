﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServerSide.Sockets
{
    public enum Header : byte
    {
        DISCONECT,
        MOVEMENT,
        REFRESH,
        NAME
    }
    public enum SubMovementHeader : byte
    {
        HORIZONTAL_MOVEMENT,
        JUMP,
        SPIN
    }
}
