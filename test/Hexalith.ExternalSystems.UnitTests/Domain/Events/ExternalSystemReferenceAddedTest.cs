namespace Hexalith.ExternalSystems.UnitTests.Domain.Events;

using FluentAssertions;

using Hexalith.Domain.Events;
using Hexalith.ExternalSystems.Events;
using Hexalith.TestMocks;

public class ExternalSystemReferenceAddedTest : PolymorphicSerializationTestBase<ExternalSystemReferenceAdded, BaseEvent>
{
    [Fact]
    public void AddExternalSystemReferenceCheckAggregateId()
    {
        ExternalSystemReferenceAdded c = DummyExternalSystemsDomainHelper.DummyExternalSystemReferenceAdded();
        _ = c.AggregateId.Should().Be("ExternalSystemReference-PART1-Company1-ORIG1-Customer-EXT123");
    }

    public override object ToSerializeObject()
        => DummyExternalSystemsDomainHelper.DummyExternalSystemReferenceAdded();
}