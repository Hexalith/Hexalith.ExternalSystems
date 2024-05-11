namespace Hexalith.ExternalSystems.UnitTests.Domain.Events;

using FluentAssertions;

using Hexalith.Domain.Events;
using Hexalith.ExternalSystems.Events;
using Hexalith.TestMocks;

public class ExternalSystemReferenceRemovedTest : PolymorphicSerializationTestBase<ExternalSystemReferenceRemoved, BaseEvent>
{
    [Fact]
    public void AddExternalSystemReferenceCheckAggregateId()
    {
        ExternalSystemReferenceRemoved c = DummyExternalSystemsDomainHelper.DummyExternalSystemReferenceRemoved();
        _ = c.AggregateId.Should().Be("ExternalSystemReference-PART1-Company1-ORIG1-Customer-EXT123");
    }

    public override object ToSerializeObject()
        => DummyExternalSystemsDomainHelper.DummyExternalSystemReferenceRemoved();
}