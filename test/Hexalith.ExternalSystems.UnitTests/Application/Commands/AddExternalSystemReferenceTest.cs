namespace Hexalith.ExternalSystems.UnitTests.Application.Commands;

using FluentAssertions;

using Hexalith.Application.Commands;
using Hexalith.ExternalSystems.Application.Commands;
using Hexalith.TestMocks;

public class AddExternalSystemReferenceTest : PolymorphicSerializationTestBase<AddExternalSystemReference, BaseCommand>
{
    [Fact]
    public void AddExternalSystemReferenceCheckAggregateId()
    {
        AddExternalSystemReference c = DummyExternalSystemsApplicationHelper
            .DummyAddExternalSystemReference();
        _ = c.AggregateId.Should().Be("ExternalSystemReference-PART1-Company1-ORIG1-Customer-EXT123");
    }

    public override object ToSerializeObject() => DummyExternalSystemsApplicationHelper.DummyAddExternalSystemReference();
}