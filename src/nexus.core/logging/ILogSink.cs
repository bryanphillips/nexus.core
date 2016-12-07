// Copyright Malachi Griffie
// 
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System;

namespace nexus.core.logging
{
   /// <summary>
   /// Instances of <see cref="ILogSink" /> can be registered to a log with <see cref="ILogControl.AddSink" />, after which
   /// the sink will receive every entry that passes the log's log level.
   /// </summary>
   public interface ILogSink
   {
      /// <summary>
      /// This sink will handle the given <see cref="ILogEntry" /> however it sees fit
      /// </summary>
      /// <param name="entry">The current log entry</param>
      /// <param name="sequenceNumber">The sequence number of this entry, a monotonically increasing value for each new entry.</param>
      void Handle( ILogEntry entry, Int32 sequenceNumber );
   }
}