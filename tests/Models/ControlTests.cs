using Xunit;
using openrmf_api_controls.Models;

namespace tests.Models
{
    public class ControlTests
    {
        [Fact]
        public void Test_NewControlIsValid()
        {
            Control control = new Control();

            // Testing
            Assert.False(control == null);
        }
    
        [Fact]
        public void Test_ControlWithDataIsValid()
        {
            ChildControl childControl = new ChildControl();

            childControl.description = "My Child Description";
            childControl.number = "AC-1.1";

            Control control = new Control();

            control.family = "AC";
            control.number = "AC-1";
            control.title = "My Title";
            control.priority = "P1";
            control.childControls.Add(childControl);
            control.supplementalGuidance = "My supplemental guidance.";

            // Testing
            Assert.True(control.family == "AC");
            Assert.True(control.number == "AC-1");
            Assert.True(control.title == "My Title");
            Assert.True(control.priority == "P1");
            Assert.True(control.supplementalGuidance == "My supplemental guidance.");
            Assert.True(control.childControls.Count == 1);

            Assert.True(childControl.description == "My Child Description");
            Assert.True(childControl.number == "AC-1.1");
        }
    }
}
