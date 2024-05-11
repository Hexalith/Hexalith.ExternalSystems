// ***********************************************************************
// Assembly         : Hexalith.Domain.Parties
// Author           : Jérôme Piquot
// Created          : 08-21-2023
//
// Last Modified By : Jérôme Piquot
// Last Modified On : 08-28-2023
// ***********************************************************************
// <copyright file="ExternalSystemReference.cs" company="Fiveforty SAS Paris France">
//     Copyright (c) Fiveforty SAS Paris France. All rights reserved.
//     Licensed under the MIT license.
//     See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Hexalith.ExternalSystems.Domain.Aggregates;

using System.Runtime.Serialization;

using Hexalith.Domain.Aggregates;
using Hexalith.Domain.Events;
using Hexalith.Domain.Exceptions;
using Hexalith.ExternalSystems.Domain.Helpers;
using Hexalith.ExternalSystems.Events;

/// <summary>
/// Class Customer.
/// Implements the <see cref="Aggregate" />
/// Implements the <see cref="IAggregate" />.
/// </summary>
/// <seealso cref="Aggregate" />
/// <seealso cref="IAggregate" />
[DataContract]
public record ExternalSystemReference(
    [property: DataMember] string PartitionId,
    [property: DataMember] string CompanyId,
    [property: DataMember] string SystemId,
    [property: DataMember] string ReferenceAggregateName,
    [property: DataMember] string ExternalId,
    [property: DataMember] string? ReferenceAggregateId) : Aggregate
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalSystemReference" /> class.
    /// </summary>
    /// <param name="mapped">The mapped.</param>
    public ExternalSystemReference(ExternalSystemReferenceAdded mapped)
        : this(
              (mapped ?? throw new ArgumentNullException(nameof(mapped))).PartitionId,
              mapped.CompanyId,
              mapped.SystemId,
              mapped.ReferenceAggregateName,
              mapped.ExternalId,
              mapped.ReferenceAggregateId)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalSystemReference"/> class.
    /// </summary>
    public ExternalSystemReference()
        : this(
        string.Empty,
        string.Empty,
        string.Empty,
        string.Empty,
        string.Empty,
        string.Empty)
    {
    }

    /// <inheritdoc/>
    public override string AggregateName => ExternalSystemDomainHelper.ExternalSystemReferenceAggregateName;

    /// <inheritdoc/>
    public override string AggregateId
        => ExternalSystemDomainHelper
            .GetExternalSystemReferenceAggregateId(
                PartitionId,
                CompanyId,
                SystemId,
                ReferenceAggregateName,
                ExternalId);

    /// <inheritdoc/>
    public override (IAggregate Aggregate, IEnumerable<BaseEvent> Events) Apply(BaseEvent domainEvent)
    {
        ArgumentNullException.ThrowIfNull(domainEvent);
        return (domainEvent switch
        {
            ExternalSystemReferenceRemoved => this with { ReferenceAggregateId = null },
            ExternalSystemReferenceAdded added => this with { ReferenceAggregateId = added.ReferenceAggregateId },
            _ => throw new InvalidAggregateEventException(this, domainEvent, false),
        }, []);
    }

    /// <inheritdoc/>
    public override bool IsInitialized() => !string.IsNullOrWhiteSpace(ReferenceAggregateName);

    /// <inheritdoc/>
    protected override string DefaultAggregateId() => ExternalSystemDomainHelper.GetExternalSystemReferenceAggregateId(PartitionId, CompanyId, SystemId, ReferenceAggregateName, ExternalId);
}