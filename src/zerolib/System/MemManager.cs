// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Internal.Runtime.CompilerHelpers;

namespace System
{
    public static class MemManager
    {
        public static void Free(object obj)
        {
            if (obj != null)
            {
                StartupCodeHelpers.RhSuppressFinalize(obj);
            }
        }
    }
}
