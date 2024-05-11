// <copyright file="DummyExternalSystemsApplicationHelper.cs" company="Fiveforty SAS Paris France">
//     Copyright (c) Fiveforty SAS Paris France. All rights reserved.
//     Licensed under the MIT license.
//     See LICENSE file in the project root for full license information.
// </copyright>

namespace Hexalith.ExternalSystems.UnitTests.Domain;

using Hexalith.ExternalSystems.Domain.Aggregates;
using Hexalith.ExternalSystems.Events;

public static class DummyExternalSystemsDomainHelper
{
    public static ExternalSystemReference DummyExternalSystemReference()
            => new(
            "PART1",
            "Company1",
            "ORIG1",
            "Customer",
            "EXT123",
            "CUS123");

    public static ExternalSystemReferenceAdded DummyExternalSystemReferenceAdded()
                => new(
            "PART1",
            "Company1",
            "ORIG1",
            "Customer",
            "EXT123",
            "CUS123");

    public static ExternalSystemReferenceRemoved DummyExternalSystemReferenceRemoved()
            => new(
            "PART1",
            "Company1",
            "ORIG1",
            "Customer",
            "EXT123",
            "CUS123");
}