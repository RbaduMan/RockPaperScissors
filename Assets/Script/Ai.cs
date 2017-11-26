using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour {

    private int score;
    public GameObject[] sprites;
    public RockPaperScissorsEnum.RPS choice;

    public Ai()
    {
        score = 0;
    }


    public void SelectAction()
    {
        int randNum = Random.Range(1, 4);

        switch (randNum)
        {
            case 1:
                {
                    choice = RockPaperScissorsEnum.RPS.ROCK;
                    break;
                }
            case 2:
                {
                    choice = RockPaperScissorsEnum.RPS.PAPER;
                    break;
                }
            case 3:
                {
                    choice = RockPaperScissorsEnum.RPS.SCISSORS;
                    break;
                }
        }

        RenderSelected(choice);
    }

    void RenderSelected(RockPaperScissorsEnum.RPS choice)
    {
        if (this.choice == RockPaperScissorsEnum.RPS.ROCK)
        {
            sprites[0].SetActive(true);
        }
        else if (this.choice == RockPaperScissorsEnum.RPS.PAPER)
        {
            sprites[1].SetActive(true);
        }
        else
        {
            sprites[2].SetActive(true);
        }
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
