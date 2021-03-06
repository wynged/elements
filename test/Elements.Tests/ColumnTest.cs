using Elements.Geometry;
using Elements.Geometry.Profiles;
using Xunit;

namespace Elements.Tests
{
    public class ColumnTest : ModelTest
    {        
        [Fact]
        public void Column()
        {
            this.Name = "Elements_Column";

            var profile = WideFlangeProfileServer.Instance.GetProfileByName("W44x335");
            var column = new Column(Vector3.Origin, 3.0, profile, BuiltInMaterials.Steel);
            
            this.Model.AddElement(column);
        }
    }
}