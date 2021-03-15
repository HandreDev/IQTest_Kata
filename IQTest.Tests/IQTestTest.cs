using NUnit.Framework;
using System;
using System.Linq;

namespace IQTest.Tests
{
    public class IQTestTest
    {
        [Test]
        public void Test1()
        {
            //Act
            var actual = Test("2 4 7 8 10");
            var expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            //Act
            var actual = Test("1 2 2");
            var expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            //Act
            var actual = Test("88 96 66 51 14 88 2 92 18 72 18 88 20 30 4 82 90 100 24 46");
            var expected = 4;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            //Act
            var actual = Test("100 99 100");
            var expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            //Act
            var actual = Test("5 3 2");
            var expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test6()
        {
            //Act
            var actual = Test("43 28 1 91");
            var expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test7()
        {
            //Act
            var actual = Test("20 94 56 50 10 98 52 32 14 22 24 60 4 8 98 46 34 68 82 82 98 90 50 20 78 49 52 94 64 36");
            var expected = 26;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test8()
        {
            //Act
            var actual = Test("79 27 77 57 37 45 27 49 65 33 57 21 71 19 75 85 65 61 23 97 85 9 23 1 9 3 99 77 77 21 79 69 15 37 15 7 93 81 13 89 91 31 45 93 15 97 55 80 85 83");
            var expected = 48;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test9()
        {
            //Act
            var actual = Test("100 100 1");
            var expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test10()
        {
            //Act
            var actual = Test("9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9");
            var expected = 32;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public static int Test(string numbers)
        {
            var numberList = Array.ConvertAll(numbers.Split(' '), int.Parse);

            var evenNumbers = numberList.LongCount(number => number % 2 == 0);

            if (evenNumbers == 1)
            {
                return 1 + Array.IndexOf(numberList, numberList.First(number => number % 2 == 0));
            }
            else
            {
                return 1 + Array.IndexOf(numberList, numberList.First(number => number % 2 == 1));
            }
        }
    }
}