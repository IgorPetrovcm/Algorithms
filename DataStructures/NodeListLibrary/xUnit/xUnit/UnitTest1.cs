namespace xUnit;
using NodeListLib;
using System;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        NodeList<int> nodes = new NodeList<int>();

        for (int i = 0; i < 10; i++)
        {
            nodes.Add(i);
        }

        Assert.Equal(10, nodes.Count);
    }
}