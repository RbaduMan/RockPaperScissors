using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PlayerTest {

    Player player;

    [OneTimeSetUpAttribute]
    public void TestSetUp()
    {
        player = new Player();
    }

    [Test]
    public void TestInitialState()
    {
        Assert.AreEqual(0, player.GetScore());
    }

    [Test]
    public void TestUpdateScore()
    {
        player.IncreaseScore();
        Assert.AreEqual(1, player.GetScore());
    }
}
