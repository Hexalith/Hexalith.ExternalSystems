﻿// ***********************************************************************
// Assembly         : Hexalith.Domain.Parties
// Author           : Jérôme Piquot
// Created          : 08-21-2023
//
// Last Modified By : Jérôme Piquot
// Last Modified On : 09-12-2023
// ***********************************************************************
// <copyright file="AddExternalSystemReference.cs" company="Fiveforty SAS Paris France">
//     Copyright (c) Fiveforty SAS Paris France. All rights reserved.
//     Licensed under the MIT license.
//     See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Hexalith.ExternalSystems.Commands;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

using Hexalith.Extensions;

/// <summary>
/// Class ExternalSystemReferenceMapped.
/// Implements the <see cref="ExternalSystemReferenceCommand" />.
/// </summary>
/// <seealso cref="ExternalSystemReferenceCommand" />
[DataContract]
[Serializable]
public class AddExternalSystemReference : ExternalSystemReferenceCommand
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddExternalSystemReference"/> class.
    /// </summary>
    /// <param name="partitionId">The partition identifier.</param>
    /// <param name="companyId">The company identifier.</param>
    /// <param name="systemId">The system identifier.</param>
    /// <param name="referenceAggregateName">Name of the reference aggregate.</param>
    /// <param name="externalId">The external identifier.</param>
    /// <param name="referenceAggregateId">The reference aggregate identifier.</param>
    [JsonConstructor]
    public AddExternalSystemReference(
        string partitionId,
        string companyId,
        string systemId,
        string referenceAggregateName,
        string externalId,
        string referenceAggregateId)
        : base(partitionId, companyId, systemId, referenceAggregateName, externalId, referenceAggregateId)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AddExternalSystemReference" /> class.
    /// </summary>
    [Obsolete(DefaultLabels.ForSerializationOnly, true)]
    public AddExternalSystemReference()
    {
    }
}