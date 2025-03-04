using ConsoleApp7;
using NUnit.Framework;

namespace ConsoleApp7.Tests;

[TestFixture]
[TestOf(typeof(SomeClass))]
public class SomeClassTest
{

    [Test]
    public void MyFooTest()
    {
        Assert.Equals(new SomeClass().foo() , 1);
    }
}