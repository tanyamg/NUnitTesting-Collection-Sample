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
        [Test]
        public void Test_Collections_Add()
        {
            // Arrange
            var nums = new Collection<int>();

            // Act
            nums.Add(5);
            nums.Add(6);

            // Assert
            Assert.That(nums.ToString(), Is.EqualTo("[5, 6]"));
        }

        [Test]
        public void Test_Collection_AddRangeWithGrow() //only rewrite
        {
            var nums = new Collection<int>();
            int oldCapacity = nums.Capacity;
            var newNums = Enumerable.Range(1000, 2000).ToArray();
            nums.AddRange(newNums);
            string expectedNums = "[" + string.Join(", ", newNums) + "]";
            Assert.That(nums.ToString(), Is.EqualTo(expectedNums));
            Assert.That(nums.Capacity, Is.GreaterThanOrEqualTo(oldCapacity));
            Assert.That(nums.Capacity, Is.GreaterThanOrEqualTo(nums.Count));
        }

        [Test]
        public void Test_Collection_CountAndCapacity()
        {
            var nums = new Collection<int>(5, 6);

            Assert.That(nums.Count, Is.EqualTo(2), "Check for count");
            Assert.That(nums.Capacity, Is.GreaterThanOrEqualTo(nums.Count));
        }

        [Test]
       public void Test_Collection_AddSimbol()
        {
            var coll = new Collection<string>("Ivan", "Peter");

            //Act
            coll.Add("Gosho");

            //Very interesting some variations in string
            //Assert.That(coll.ToString, Is.EquivalentTo(new string[] {"Ivan", "Peter", "Gosho" }));

            Assert.That(coll.ToString(), Is.EqualTo("[Ivan, Peter, Gosho]"));
        }

        [Test]
        public void Test_Collection_GetByIndex()
        { 
            var collection = new Collection<int>(5, 6, 7);
            var item = collection[1];

            Assert.That(item.ToString(), Is.EqualTo("6"));
        }

        [Test]
        public void Test_Collection_SetByIndex()
        {
            var collection = new Collection<int>(5, 6, 7);
            collection[1] = 666;

            Assert.That(collection.ToString(), Is.EqualTo("[5, 666, 7]"));
        }

        [Test]
        public void Test_Collection_GetByInvalidIndex()
        {
            var coll = new Collection<string>("Dara", "Tanya");

            Assert.That(() => { var name = coll[500]; },
            Throws.InstanceOf<ArgumentOutOfRangeException>());

        }





    }
}