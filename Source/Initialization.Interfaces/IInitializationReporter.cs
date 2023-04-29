// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IInitializationReporter.cs" company="Sundews">
// Copyright (c) Sundews. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Initialization.Interfaces;

/// <summary>
/// Interface for implementing a <see cref="IInitializable"/> reporter.
/// </summary>
public interface IInitializationReporter
{
    /// <summary>
    /// Called when an initializable has been initialized.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="initializable">The initializable.</param>
    void Initialized(object source, IInitializable initializable);

    /// <summary>
    /// Called when an async initializable has been initialized.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="initializable">The initializable.</param>
    void Initialized(object source, IAsyncInitializable initializable);
}