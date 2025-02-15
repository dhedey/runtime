// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
#if NET7_0_OR_GREATER
using System.Runtime.InteropServices.GeneratedMarshalling;
#endif

internal static partial class Interop
{
    internal static partial class Shell32
    {
        [GeneratedDllImport(Libraries.Shell32, EntryPoint = "ExtractAssociatedIconW", CharSet = CharSet.Unicode)]
        internal static unsafe partial IntPtr ExtractAssociatedIcon(
#if NET7_0_OR_GREATER
            [MarshalUsing(typeof(HandleRefMarshaller))]
#endif
            HandleRef hInst, char* iconPath, ref int index);
    }
}
