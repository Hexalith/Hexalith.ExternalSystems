﻿// ***********************************************************************
// Assembly         : Hexalith.UnitTests
// Author           : Jérôme Piquot
// Created          : 12-07-2023
//
// Last Modified By : Jérôme Piquot
// Last Modified On : 12-07-2023
// ***********************************************************************
// <copyright file="SelectIntercompanyDropshipDeliveryForCustomerTest.cs" company="Fiveforty SAS Paris France">
//     Copyright (c) Fiveforty SAS Paris France. All rights reserved.
//     Licensed under the MIT license.
//     See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Hexalith.UnitTests.Core.Domain.Parties.Events;

using FluentAssertions;

using Hexalith.Application.Commands;
using Hexalith.Application.Parties.Commands;
using Hexalith.Domain.Events;
using Hexalith.TestMocks;
using Hexalith.UnitTests.Core.Application.Parties;

/// <summary>
/// Class SelectIntercompanyDropshipDeliveryForCustomerTest.
/// Implements the <see cref="Hexalith.TestMocks.PolymorphicSerializationTestBase{Hexalith.Domain.Events.SelectIntercompanyDropshipDeliveryForCustomer, Hexalith.Domain.Events.BaseEvent}" />.
/// </summary>
/// <seealso cref="Hexalith.TestMocks.PolymorphicSerializationTestBase{Hexalith.Domain.Events.SelectIntercompanyDropshipDeliveryForCustomer, Hexalith.Domain.Events.BaseEvent}" />
public class SelectIntercompanyDropshipDeliveryForCustomerTest : PolymorphicSerializationTestBase<SelectIntercompanyDropshipDeliveryForCustomer, BaseCommand>
{
    /// <summary>
    /// Defines the test method CustomerRegisteredCheckAggregateId.
    /// </summary>
    [Fact]
    public void CustomerRegisteredCheckAggregateId()
    {
        SelectIntercompanyDropshipDeliveryForCustomer e = ToSerializeObject() as SelectIntercompanyDropshipDeliveryForCustomer;
        _ = e.AggregateId.Should().Be("Customer-PART1-Company1-ORIG1-Cust123456");
    }

    /// <summary>
    /// Converts to serialize object.
    /// </summary>
    /// <returns>System.Object.</returns>
    public override object ToSerializeObject() => DummyPartiesApplicationHelper.DummySelectIntercompanyDropshipDeliveryForCustomer();
}