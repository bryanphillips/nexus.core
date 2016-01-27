﻿// Copyright Malachi Griffie
// 
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.
using System;
using System.Diagnostics;

namespace nexus.core.logging.sink
{
   public class TraceLogSink : ILogSink
   {
      public TraceLogSink()
      {
#if !DEBUG
   // ensure that the default listener is removed in release mode
         Trace.Listeners.Remove( "Default" );
#endif
      }

      public void Handle( ILogEntry entry, Deferred<String> serializedEntry )
      {
         switch(entry.Severity)
         {
            case LogLevel.Warn:
               Trace.TraceWarning( serializedEntry.Value );
               break;
            case LogLevel.Error:
               Trace.TraceError( serializedEntry.Value );
               break;
            case LogLevel.Trace:
            case LogLevel.Info:
            default:
               Trace.TraceInformation( serializedEntry.Value );
               break;
         }
      }
   }
}