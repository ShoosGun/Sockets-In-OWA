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
        NAME,
        OTHER //Quando se receber algo advindo de um plugin (por exemplo) ele irá primeiro enviar esse Header, ai (no estilo GlobalEvent do Outer Wilds) 
              //enviar o resto do pacote para o plugin fazer o que quiser com ele
    }
}
