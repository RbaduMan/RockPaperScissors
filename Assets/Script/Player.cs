using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int score;
    public GameObject[] sprites;
    public RockPaperScissorsEnum.RPS choice;

    public Player()
    {
        score = 0;
    }

    public void SelectRock()
    {
        choice = RockPaperScissorsEnum.RPS.ROCK;
        GameplayManager.instance.Duel();
    }


    public void SelectPaper()
    {
        choice = RockPaperScissorsEnum.RPS.PAPER;
        GameplayManager.instance.Duel();
    }

    public void SelectScissors()
    {
        choice = RockPaperScissorsEnum.RPS.SCISSORS;
        GameplayManager.instance.Duel();
    }

    public void ClearSelectedChoice()
    {
        foreach (GameObject item in sprites)
        {
            item.SetActive(false);
        }
    }

    public void IncreaseScore()
    {
        score++;
    }

    public int GetScore()
    {
        return score;
    }
}

