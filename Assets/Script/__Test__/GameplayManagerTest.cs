using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class GameplayManagerTest {

    GameplayManager gm;

    [OneTimeSetUpAttribute]
    public void TestSetUp()
    {
        gm = new GameplayManager();
        gm.player = new Player();
        gm.opponent = new Ai();
    }

    [Test]
    public void TestWinCondition()
    {
        gm.player.choice = RockPaperScissorsEnum.RPS.ROCK;
        gm.opponent.choice = RockPaperScissorsEnum.RPS.SCISSORS;
        Assert.AreEqual("Win", gm.GetGameStatus());

        gm.player.choice = RockPaperScissorsEnum.RPS.SCISSORS;
        gm.opponent.choice = RockPaperScissorsEnum.RPS.PAPER;
        Assert.AreEqual("Win", gm.GetGameStatus());

        gm.player.choice = RockPaperScissorsEnum.RPS.PAPER;
        gm.opponent.choice = RockPaperScissorsEnum.RPS.ROCK;
        Assert.AreEqual("Win", gm.GetGameStatus());
    }

    [Test]
    public void TestLoseCondition()
    {
        gm.player.choice = RockPaperScissorsEnum.RPS.ROCK;
        gm.opponent.choice = RockPaperScissorsEnum.RPS.PAPER;
        Assert.AreEqual("Lose", gm.GetGameStatus());

        gm.player.choice = RockPaperScissorsEnum.RPS.PAPER;
        gm.opponent.choice = RockPaperScissorsEnum.RPS.SCISSORS;
        Assert.AreEqual("Lose", gm.GetGameStatus());

        gm.player.choice = RockPaperScissorsEnum.RPS.SCISSORS;
        gm.opponent.choice = RockPaperScissorsEnum.RPS.ROCK;
        Assert.AreEqual("Lose", gm.GetGameStatus());
    }

    [Test]
    public void TestDrawCondition()
    {
        gm.player.choice = RockPaperScissorsEnum.RPS.ROCK;
        gm.opponent.choice = RockPaperScissorsEnum.RPS.ROCK;
        Assert.AreEqual("Draw", gm.GetGameStatus());

        gm.player.choice = RockPaperScissorsEnum.RPS.PAPER;
        gm.opponent.choice = RockPaperScissorsEnum.RPS.PAPER;
        Assert.AreEqual("Draw", gm.GetGameStatus());

        gm.player.choice = RockPaperScissorsEnum.RPS.SCISSORS;
        gm.opponent.choice = RockPaperScissorsEnum.RPS.SCISSORS;
        Assert.AreEqual("Draw", gm.GetGameStatus());
    }

}
