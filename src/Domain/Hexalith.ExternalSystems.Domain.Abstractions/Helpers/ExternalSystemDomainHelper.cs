namespace Hexalith.ExternalSystems.Domain.Helpers;

using System.Diagnostics.CodeAnalysis;

using Hexalith.Domain.Aggregates;

/// <summary>
/// Inventory helper.
/// </summary>
public static class ExternalSystemDomainHelper
{
    /// <summary>
    /// Gets the aggregate name for the ExternalSystemReference.
    /// </summary>
    public static string ExternalSystemReferenceAggregateName => "ExternalSystemReference";

    /// <summary>
    /// Gets the identifier separator.
    /// </summary>
    /// <value>The identifier separator.</value>
    public static char IdSeparator => '-';

    /// <summary>
    /// Gets the aggregate ID for the ExternalSystemReference.
    /// </summary>
    /// <param name="partitionId">The partition ID.</param>
    /// <param name="companyId">The company ID.</param>
    /// <param name="systemId">The system ID.</param>
    /// <param name="referenceAggregateName">The reference aggregate name.</param>
    /// <param name="externalId">The external ID.</param>
    /// <returns>The aggregate ID.</returns>
    public static string GetExternalSystemReferenceAggregateId(
    [NotNull] string partitionId,
    [NotNull] string companyId,
    [NotNull] string systemId,
    [NotNull] string referenceAggregateName,
    [NotNull] string externalId)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(partitionId);
        ArgumentException.ThrowIfNullOrWhiteSpace(companyId);
        ArgumentException.ThrowIfNullOrWhiteSpace(systemId);
        ArgumentException.ThrowIfNullOrWhiteSpace(referenceAggregateName);
        ArgumentException.ThrowIfNullOrWhiteSpace(externalId);
        return Aggregate.Normalize(
            ExternalSystemReferenceAggregateName + IdSeparator + partitionId + IdSeparator + companyId + IdSeparator + systemId + IdSeparator + referenceAggregateName + IdSeparator + externalId);
    }
}