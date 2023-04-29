// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IInitializable.cs" company="Sundews">
// Copyright (c) Sundews. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Initialization.Interfaces;

/// <summary>
/// Interface for implementing initializable objects.
/// </summary>
public interface IInitializable
{
    /// <summary>
    /// Performs initialization.
    /// </summary>
    void Initialize();
}