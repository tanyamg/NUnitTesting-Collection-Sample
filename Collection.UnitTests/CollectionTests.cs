using Collections;

namespace Collection.UnitTests
{
    public class CollectionTests
    {
        
        [Test]
        public void Test_Collection_EmptyConstructor() 
        {
            // Arrange
            var nums = new Collection<int>();

            // Assert
            Assert.That(nums.ToString(), Is.EqualTo("[]"));

        }
        [Test]  
        public void Test_Collection_ConstructorSingleItem()
        {
            //Arrange
            var nums = new Collection<int>(5);

            //Assert
            Assert.That(nums[0], Is.EqualTo(5));
        }

        [Test]
        public void Test_Collection_ConstructorMultipleItems()
        {
            //Arrange
            var nums = new Collection<int>(5, 10, 15);

            //Assert
            Assert.That(nums.ToString(), Is.EqualTo("[5, 10, 15]"));
        }



    }
}