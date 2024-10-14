namespace solution.Tests;
using NUnit.Framework;
using solution.Models;
using solution.Controllers;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        
        Assert.Pass();
    }
    [Test]
    public void Testinsertingnamesintomodel()
    {
        teammodel.makenames(["name1", "name2"]);
        if(teammodel.names[0]=="name1"){
            Assert.Pass();
        }
        Assert.Fail();
    }
    

}