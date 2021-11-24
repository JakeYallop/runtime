// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Ole32
    {
#pragma warning disable DLLIMPORTGENANALYZER015 // Use 'GeneratedDllImportAttribute' instead of 'DllImportAttribute' to generate P/Invoke marshalling code at compile time
        // TODO: [DllImportGenerator] Switch to use GeneratedDllImport once we annotate blittable types used in interop in CoreLib (like Guid)
        [DllImport(Interop.Libraries.Ole32, CharSet = CharSet.Unicode)]
        internal static extern int CLSIDFromProgID(string lpszProgID, out Guid lpclsid);
#pragma warning restore DLLIMPORTGENANALYZER015
    }
}
