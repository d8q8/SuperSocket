﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocket.SocketBase.Config
{
    public interface IRootConfig
    {
        int MaxWorkingThreads { get; }

        int MinWorkingThreads { get; }

        int MaxCompletionPortThreads { get; }

        int MinCompletionPortThreads { get; }
    }
}
