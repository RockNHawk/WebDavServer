﻿// <copyright file="IfUnmodifiedSinceHeader.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using System;

using FubarDev.WebDavServer.FileSystem;
using FubarDev.WebDavServer.Props.Converters;

namespace FubarDev.WebDavServer.Model.Headers
{
    public class IfUnmodifiedSinceHeader : IIfHttpMatcher
    {
        public IfUnmodifiedSinceHeader(DateTime lastWriteTimeUtc)
        {
            LastWriteTimeUtc = lastWriteTimeUtc;
        }

        public DateTime LastWriteTimeUtc { get; }

        public static IfUnmodifiedSinceHeader Parse(string s)
        {
            return new IfUnmodifiedSinceHeader(DateTimeRfc1123Converter.Parse(s));
        }

        public bool IsMatch(IEntry entry, EntityTag etag)
        {
            return entry.LastWriteTimeUtc <= LastWriteTimeUtc;
        }
    }
}
