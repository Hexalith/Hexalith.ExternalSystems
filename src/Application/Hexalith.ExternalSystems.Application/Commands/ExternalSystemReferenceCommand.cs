﻿// ***********************************************************************
// Assembly         : Hexalith.Domain.Parties
// Author           : Jérôme Piquot
// Created          : 08-21-2023
//
// Last Modified By : Jérôme Piquot
// Last Modified On : 08-28-2023
// ***********************************************************************
// <copyright file="ExternalSystemReferenceCommand.cs" company="Fiveforty SAS Paris France">
//     Copyright (c) Fiveforty SAS Paris France. All rights reserved.
//     Licensed under the MIT license.
//     See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Hexalith.ExternalSystems.Application.Commands;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

using Hexalith.Application.Organizations.Commands;
using Hexalith.Domain.Events;
using Hexalith.Extensions;
using Hexalith.ExternalSystems.Domain.Helpers;

/// <summary>
/// Class CustomerEvent.
/// Implements the <see cref="BaseEvent" />.
/// </summary>
/// <seealso cref="BaseEvent" />
[DataContract]
[Serializable]
public class ExternalSystemReferenceCommand : PartitionedCommand
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalSystemReferenceCommand"/> class.
    /// </summary>
    /// <param name="partitionId">The partition identifier.</param>
    /// <param name="companyId">The company identifier.</param>
    /// <param name="systemId">The system identifier.</param>
    /// <param name="referenceAggregateName">Name of the reference aggregate.</param>
    /// <param name="externalId">The external identifier.</param>
    /// <param name="referenceAggregateId">The reference aggregate identifier.</param>
    [JsonConstructor]
    protected ExternalSystemReferenceCommand(
        string partitionId,
        string companyId,
        string systemId,
        string referenceAggregateName,
        string externalId,
        string referenceAggregateId)
        : base(partitionId)
    {
        SystemId = systemId;
        ReferenceAggregateName = referenceAggregateName;
        ExternalId = externalId;
        ReferenceAggregateId = referenceAggregateId;
        CompanyId = companyId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalSystemReferenceCommand" /> class.
    /// </summary>
    [Obsolete(DefaultLabels.ForSerializationOnly, true)]
    protected ExternalSystemReferenceCommand() => CompanyId = SystemId = ReferenceAggregateId = ReferenceAggregateName = ExternalId = string.Empty;

    /// <summary>
    /// Gets or sets the company identifier.
    /// </summary>
    /// <value>The company identifier.</value>
    [DataMember(Order = 2)]
    [JsonPropertyOrder(2)]
    public string CompanyId { get; set; }

    /// <summary>
    /// Gets or sets the external identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [DataMember(Order = 5)]
    [JsonPropertyOrder(5)]
    public string ExternalId { get; set; }

    /// <summary>
    /// Gets or sets the aggregate type name.
    /// </summary>
    /// <value>The identifier.</value>
    [DataMember(Order = 6)]
    [JsonPropertyOrder(6)]
    public string ReferenceAggregateId { get; set; }

    /// <summary>
    /// Gets or sets the aggregate type name.
    /// </summary>
    /// <value>The identifier.</value>
    [DataMember(Order = 4)]
    [JsonPropertyOrder(4)]
    public string ReferenceAggregateName { get; set; }

    /// <summary>
    /// Gets or sets the system identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [DataMember(Order = 3)]
    [JsonPropertyOrder(3)]
    public string SystemId { get; set; }

    /// <inheritdoc/>
    protected override string DefaultAggregateId() => ExternalSystemDomainHelper.GetExternalSystemReferenceAggregateId(PartitionId, CompanyId, SystemId, ReferenceAggregateName, ExternalId);

    /// <inheritdoc/>
    protected override string DefaultAggregateName() => ExternalSystemDomainHelper.ExternalSystemReferenceAggregateName;
}