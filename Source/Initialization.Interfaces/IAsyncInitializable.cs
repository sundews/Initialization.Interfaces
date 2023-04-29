// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAsyncInitializable.cs" company="Sundews">
// Copyright (c) Sundews. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Initialization.Interfaces;

using System.Threading.Tasks;

/// <summary>
/// Interface for implementing initializable objects.
/// </summary>
public interface IAsyncInitializable
{
    /// <summary>
    /// Performs initialization asynchronously.
    /// </summary>
    /// <returns>An async task.</returns>
    ValueTask InitializeAsync();
}