using Xunit;
using openrmf_api_controls.Models;

namespace tests.Models
{
    public class ControlSetTests
    {
        [Fact]
        public void Test_NewControlSetIsValid()
        {
            ControlSet controlSet = new ControlSet();

            // Testing
            Assert.False(controlSet == null);
        }

        [Fact]
        public void Test_ControlSetWidhDataIsValid()
        {
            ControlSet controlSet = new ControlSet();

            controlSet.family = "family";
            controlSet.number = "number";
            controlSet.title = "title";
            controlSet.priority = "priority";
            controlSet.lowimpact = true;
            controlSet.moderateimpact = true;
            controlSet.highimpact = true;
            controlSet.supplementalGuidance = "supguide";
            controlSet.subControlDescription = "subcontdesc";
            controlSet.subControlNumber = "subcontnum";

            // Testing
            Assert.True(controlSet.family == "family");
            Assert.True(controlSet.number == "number");
            Assert.True(controlSet.title == "title");
            Assert.True(controlSet.priority == "priority");
            Assert.True(controlSet.lowimpact);
            Assert.True(controlSet.moderateimpact);
            Assert.True(controlSet.highimpact);
            Assert.True(controlSet.supplementalGuidance == "supguide");
            Assert.True(controlSet.subControlDescription == "subcontdesc");
            Assert.True(controlSet.subControlNumber == "subcontnum");
            Assert.False(controlSet.id == null);
            Assert.False(controlSet.indexsort == null);
        }
    }
}
