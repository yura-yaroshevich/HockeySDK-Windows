﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HockeyApp
{
    /// <summary>
    /// EventArgs for exceptions which are swallowed by HockeyApp
    /// </summary>
    public class InternalUnhandledExceptionEventArgs : EventArgs
    {
        /// <summary>
        /// The exception.
        /// </summary>
        public Exception Exception { get; internal set; }
    }
}
