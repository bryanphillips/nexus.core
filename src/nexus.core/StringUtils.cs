﻿// Copyright Malachi Griffie
// 
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;
using nexus.core.resharper;

namespace nexus.core
{
   public static class StringUtils
   {
      /// <summary>
      /// Wraps <see cref="String.Format(String,object[])" /> for more convenient use, e.g.,
      /// <code>"Value {0}".@F(argument)</code>.
      /// </summary>
      [System.Diagnostics.Contracts.Pure]
      [resharper.Pure]
      [StringFormatMethod( "format" )]
      public static String F( this String format, params Object[] args )
      {
         Contract.Requires( format != null );
         Contract.Requires( args != null );
         Contract.Ensures( Contract.Result<String>() != null );
         return String.Format( format, args );
      }

      /// <summary>
      /// Syntax sugar for <see cref="String.IsNullOrEmpty" />
      /// </summary>
      [System.Diagnostics.Contracts.Pure]
      [resharper.Pure]
      public static Boolean IsNullOrEmpty( this String value )
      {
         return String.IsNullOrEmpty( value );
      }

      /// <summary>
      /// Syntax sugar for <see cref="String.IsNullOrWhiteSpace" />
      /// </summary>
      [System.Diagnostics.Contracts.Pure]
      public static Boolean IsNullOrWhiteSpace( this String value )
      {
         //return (value == null || (value.Trim().Length == 0));
         return String.IsNullOrWhiteSpace( value );
      }

      /// <summary>
      /// Syntax sugar for <see cref="String.Join(String,String[])" />
      /// </summary>
      [System.Diagnostics.Contracts.Pure]
      [resharper.Pure]
      public static String Join( this String[] arr, String separator )
      {
         return String.Join( separator, arr );
      }

      /// <summary>
      /// Syntax sugar for <see cref="String.Join(String,System.Collections.Generic.IEnumerable{String})" />
      /// </summary>
      [System.Diagnostics.Contracts.Pure]
      [resharper.Pure]
      public static String Join( this IEnumerable<String> arr, String separator )
      {
         return String.Join( separator, arr );
      }

      /// <summary>
      /// Removes any of the individual characters in <paramref name="stripValues" /> from <paramref name="source" />
      /// </summary>
      [System.Diagnostics.Contracts.Pure]
      [resharper.Pure]
      public static String StripCharacters( this String source, String stripValues )
      {
         return source.IsNullOrEmpty() ? source : Regex.Replace( source, "[" + Regex.Escape( stripValues ) + "]", "" );
      }

      /// <summary>
      /// Removes any of the characters in <paramref name="stripValues" /> from <paramref name="source" />
      /// </summary>
      [System.Diagnostics.Contracts.Pure]
      [resharper.Pure]
      public static String StripCharacters( this String source, params Char[] stripValues )
      {
         return StripCharacters( source, String.Join( "", stripValues ) );
      }

      /// <summary>
      /// Calls regex.IsMatch() but returns false if the input is null instead of throwing an ArgumentNullException
      /// </summary>
      /// <param name="regex"></param>
      /// <param name="input"></param>
      /// <param name="startAt">The character position at which to start the search. </param>
      /// <returns></returns>
      [System.Diagnostics.Contracts.Pure]
      [resharper.Pure]
      public static Boolean Test( this Regex regex, String input, Int32? startAt = null )
      {
         if(startAt.HasValue)
         {
            return input != null && regex.IsMatch( input, startAt.Value );
         }
         return input != null && regex.IsMatch( input );
      }

      /// <summary>
      /// Convert <see cref="Int16" /> to string in a given base number system.
      /// </summary>
      public static String ToString( this Int16 value, Int32 toBase )
      {
         return Convert.ToString( value, toBase );
      }

      /// <summary>
      /// Convert <see cref="Int32" /> to string in a given base number system.
      /// </summary>
      public static String ToString( this Int32 value, Int32 toBase )
      {
         return Convert.ToString( value, toBase );
      }

      /// <summary>
      /// Convert <see cref="Int64" /> to string in a given base number system.
      /// </summary>
      public static String ToString( this Int64 value, Int32 toBase )
      {
         return Convert.ToString( value, toBase );
      }
   }
}