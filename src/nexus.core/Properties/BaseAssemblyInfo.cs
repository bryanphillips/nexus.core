﻿// Copyright Malachi Griffie
// 
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System;
using System.Reflection;

[assembly: AssemblyCompany( "nexussays" )]
[assembly: AssemblyCopyright( "Copyright Malachi Griffie <malachi@nexussays.com>" )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

#if DEBUG

[assembly: AssemblyConfiguration( "debug" )]
#else

[assembly: AssemblyConfiguration( "release" )]
#endif

// ReSharper disable once CheckNamespace

namespace nexus.core
{
   internal static partial class AssemblyInfo
   {
      internal const String PROJECT_ID = "nexus.core";
      internal const String PROJECT_DESCRIPTION = "Cross-platform library of core utility methods and data structures.";
      internal const Boolean IS_DEBUG = 
#if DEBUG
         true;
#else
         false;
#endif
   }
}