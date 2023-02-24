using DS_DOTNET;
using DSDOTNET;
using Newtonsoft.Json.Linq;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBooleanToInt()
        {
            bool a = true;
            bool b = false;
            Assert.AreEqual(1, a.ToInt());
            Assert.AreEqual(0, b.ToInt());
        }


        [TestMethod]
        public void TestSnakeCase()
        {
            var s = "Lorem IPSUM dolor Sit Amet";
            var expected1 = "lorem_ipsum_dolor_sit_amet";
            var expected2 = "lorem-ipsum-dolor-sit-amet";
            Assert.AreEqual(expected1, s.SnakeCase());
            Assert.AreEqual(expected2, s.SnakeCase('-'));
        }

        [TestMethod]
        public void TestFullTrim()
        {
            var s = " lorem ipsum dolor sit amet ";
            var expected = "lorem ipsum dolor sit amet";
            // La méthode FullTrim() doit supprimer
            // tous les espaces inutiles
            Assert.AreEqual(expected, s.FullTrim());
        }

        [TestMethod]
        public void TestEvenValues()
        {
            List<int> _values = new List<int> { 10, 20, 30, 47, -20 };

            var expectedList = new List<int> { 10, 20, 30, -20 };
            CollectionAssert.AreEqual(expectedList,
            _values.EvenValues());
        }

        [TestMethod]
        public void TestOddValues()
        {
            List<int> _values = new List<int> { 10, 20, 30, 47, -20 };

            var expectedList = new List<int> { 47 };
            CollectionAssert.AreEqual(expectedList,
            _values.OddValues());
        }

        [TestMethod]
        public void TestTransform()
        {
            List<string> tags = new List<string> { "home", "work", "sport", "travel", "cinema", "music" };

            List<string> transformedTags = tags.Transform(tag => tag.ToUpper());

            CollectionAssert.AreEqual(
                new List<string> { "HOME", "WORK", "SPORT", "TRAVEL", "CINEMA", "MUSIC" },
                transformedTags);

            List<int> list = new List<int> { 2, 4, 10, 35, -5 };

            List<int> transformedList = list.Transform(num => num * 2);
            CollectionAssert.AreEqual(
                new List<int> { 4, 8, 20, 70, -10 }, transformedList);

        }

        [TestMethod]
        public void testLinq()
        {
            var owner = new Owner("Herve", "Inisan", "mail", true);
            var owner2 = new Owner("Melo", "Mateo", "mateo.melo@outlook.fr", true);
            var e1 = new Evenement(1, owner, "lab", "desc", new DateTime(2023, 1, 1), new DateTime(2023, 3, 1), true);
            var e2 = new Evenement(2, owner, "lab2", "desc2", new DateTime(2023, 5, 1), new DateTime(2023, 5, 12), true);
            var e3 = new Evenement(3, owner2, "lab3", "desc3", new DateTime(2023, 12, 1), new DateTime(2023, 12, 4), false);

            var list = new List<Evenement>
            {
                e1, e2, e3
            };

            var res3 = list.Where(s => s.dateDebut.Month == 5).OrderBy(s => s.dateDebut).ToList();

            var res4 = list.Where(s => s.owner.lastname == "Inisan" && s.owner.firstname == "Herve" && s.confirme == true).ToList();

            var res5 = list.Where(s => s.owner.lastname == "Inisan" && s.owner.firstname == "Herve").OrderBy(s => s.dateDebut).OrderBy(s => s.label).ToList();

            var expected = new List<Evenement> { e2 };
            CollectionAssert.AreEqual(expected, res3);

            expected = new List<Evenement> { e1, e2 };
            CollectionAssert.AreEqual(expected, res4);

            expected = new List<Evenement> { e1, e2 };
            CollectionAssert.AreEqual(expected, res5);
        }

    }
}