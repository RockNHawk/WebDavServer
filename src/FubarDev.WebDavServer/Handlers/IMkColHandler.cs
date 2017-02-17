﻿// <copyright file="IMkColHandler.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using System.Threading;
using System.Threading.Tasks;

using JetBrains.Annotations;

namespace FubarDev.WebDavServer.Handlers
{
    public interface IMkColHandler : IClass1Handler
    {
        [NotNull]
        [ItemNotNull]
        Task<IWebDavResult> MkColAsync([NotNull] string path, CancellationToken cancellationToken);
    }
}