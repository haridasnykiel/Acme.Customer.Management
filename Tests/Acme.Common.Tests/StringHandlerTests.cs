using Acme.Common.Extensions;
using NUnit.Framework;

namespace Acme.Common.Tests {
    public class StringHandlerTests {

        [Test]
        public void SplitName_WhiteSpaceAddedAfterEachCapitalLetter() {
            var name = "MetalSpoon";

            var splitName = StringHandler.SplitName(name);

            Assert.AreEqual ("Metal Spoon", splitName);
        }

        [Test]
        public void SplitName_WhiteSpaceNotAddedToFirstLetter() {
            var name = "Metal";

            var splitName = name.SplitName ();

            Assert.False (splitName.Contains (" "));
        }

        [Test]
        public void SplitName_NoWhiteSpaceIfAlreadyExists() {
            var name = "Metal Spoon";

            var splitName = name.SplitName ();

            Assert.False(splitName.Contains ("  "));
        }
    }
}