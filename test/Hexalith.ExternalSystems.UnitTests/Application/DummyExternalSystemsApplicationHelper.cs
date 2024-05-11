// <copyright file="DummyExternalSystemsApplicationHelper.cs" company="Fiveforty SAS Paris France">
//     Copyright (c) Fiveforty SAS Paris France. All rights reserved.
//     Licensed under the MIT license.
//     See LICENSE file in the project root for full license information.
// </copyright>

namespace Hexalith.ExternalSystems.UnitTests.Application;

using Hexalith.ExternalSystems.Application.Commands;

public static class DummyExternalSystemsApplicationHelper
{
    public static AddExternalSystemReference DummyAddExternalSystemReference()
            => new(
            "PART1",
            "Company1",
            "ORIG1",
            "Customer",
            "EXT123",
            "CUS123");

    public static RemoveExternalSystemReference DummyRemoveExternalSystemReference()
            => new(
            "PART1",
            "Company1",
            "ORIG1",
            "Customer",
            "EXT123",
            "CUS123");
}