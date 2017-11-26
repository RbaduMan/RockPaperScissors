using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class AiTest {

    Ai ai;

    [OneTimeSetUpAttribute]
    public void TestSetUp()
    {
        ai = new Ai();
    }

    [Test]
    public void TestInitialState()
    {
        Assert.AreEqual(0, ai.GetScore());
        Assert.AreEqual(RockPaperScissorsEnum.RPS.ROCK, ai.choice);
    }

    [Test]
    public void TestUpdateScore()
    {
        ai.IncreaseScore();
        Assert.AreEqual(1, ai.GetScore());
    }
}
