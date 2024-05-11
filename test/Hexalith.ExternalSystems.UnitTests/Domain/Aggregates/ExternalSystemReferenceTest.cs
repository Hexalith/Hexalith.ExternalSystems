// ***********************************************************************
// Assembly         : Hexalith.UnitTests
// Author           : Jérôme Piquot
// Created          : 12-07-2023
//
// Last Modified By : Jérôme Piquot
// Last Modified On : 12-07-2023
// ***********************************************************************
// <copyright file="ExternalSystemReferenceTest.cs" company="Fiveforty SAS Paris France">
//     Copyright (c) Fiveforty SAS Paris France. All rights reserved.
//     Licensed under the MIT license.
//     See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Hexalith.ExternalSystems.UnitTests.Domain.Aggregates;

using FluentAssertions;

using Hexalith.ExternalSystems.Domain.Aggregates;
using Hexalith.TestMocks;

/// <summary>
/// Class ExternalSystemReferenceInformationChangedTest.
/// Implements the <see cref="Hexalith.TestMocks.PolymorphicSerializationTestBase{Events.ExternalSystemReferenceInformationChanged, Hexalith.Domain.Events.BaseEvent}" />.
/// </summary>
/// <seealso cref="Hexalith.TestMocks.PolymorphicSerializationTestBase{Events.ExternalSystemReferenceInformationChanged, Hexalith.Domain.Events.BaseEvent}" />
public class ExternalSystemReferenceTest : SerializationTestBase
{
    /// <summary>
    /// Defines the test method ExternalSystemReferenceRegisteredCheckAggregateId.
    /// </summary>
    [Fact]
    public void ExternalSystemReferenceCheckAggregateId()
    {
        ExternalSystemReference a = DummyExternalSystemsDomainHelper.DummyExternalSystemReference();
        _ = a.AggregateId.Should().Be("ExternalSystemReference-PART1-Company1-ORIG1-Customer-EXT123");
    }

    /// <summary>
    /// Converts to serialize object.
    /// </summary>
    /// <returns>System.Object.</returns>
    public override object ToSerializeObject() => DummyExternalSystemsDomainHelper.DummyExternalSystemReference();
}