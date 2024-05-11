namespace Hexalith.ExternalSystems.UnitTests.Application.Commands;

using FluentAssertions;

using Hexalith.Application.Commands;
using Hexalith.ExternalSystems.Application.Commands;
using Hexalith.TestMocks;

public class RemoveExternalSystemReferenceTest : PolymorphicSerializationTestBase<RemoveExternalSystemReference, BaseCommand>
{
    [Fact]
    public void RemoveExternalSystemReferenceCheckAggregateId()
    {
        RemoveExternalSystemReference c = DummyExternalSystemsApplicationHelper
            .DummyRemoveExternalSystemReference();
        _ = c.AggregateId.Should().Be("ExternalSystemReference-PART1-Company1-ORIG1-Customer-EXT123");
    }

    public override object ToSerializeObject() => DummyExternalSystemsApplicationHelper.DummyRemoveExternalSystemReference();
}