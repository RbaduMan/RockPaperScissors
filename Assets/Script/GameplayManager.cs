using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour {

    public static GameplayManager instance = null;
    public Player player;
    public Ai opponent;
    public Text playerScore;
    public Text aiScore;
    public Button[] playerButtons;

    // Make sure that we have only one game manager object
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void Duel()
    {
        DisableButtons();
        opponent.SelectAction();
        if (GetGameStatus().Equals("Win"))
        {
            player.IncreaseScore();
            UpdatePlayerScore("Player Score : " + player.GetScore());
        }

        else if (GetGameStatus().Equals("Lose"))
        {
            opponent.IncreaseScore();
            UpdateAIScore("Ai Score : " + opponent.GetScore());
        }

        else
        {
            //Just draw nothing happen.
        }

        StartCoroutine(ClearSelectedFromBoth());
    }

    void DisableButtons()
    {
        foreach (Button item in playerButtons)
        {
            item.interactable = false;
        }
    }

    void EnableButtons()
    {
        foreach (Button item in playerButtons)
        {
            item.interactable = true;
        }
    }

    public void UpdatePlayerScore(string message)
    {
        playerScore.text = message;
    }

    public void UpdateAIScore(string message)
    {
        aiScore.text = message;
    }

    public string GetGameStatus()
    {
        switch (player.choice)
        {
            case RockPaperScissorsEnum.RPS.ROCK:
                {
                    switch (opponent.choice)
                    {
                        case RockPaperScissorsEnum.RPS.SCISSORS:
                            {
                                return "Win"; 
                            }
                        case RockPaperScissorsEnum.RPS.PAPER:
                            {
                                return "Lose";
                            }
                        default:
                            {
                                return "Draw";
                            }
                    }
                }
            case RockPaperScissorsEnum.RPS.PAPER:
                {
                    switch (opponent.choice)
                    {
                        case RockPaperScissorsEnum.RPS.ROCK:
                            {
                                return "Win";
                            }
                        case RockPaperScissorsEnum.RPS.SCISSORS:
                            {
                                return "Lose";
                            }
                        default:
                            {
                                return "Draw";
                            }
                    }
                }
            case RockPaperScissorsEnum.RPS.SCISSORS:
                {
                    switch (opponent.choice)
                    {
                        case RockPaperScissorsEnum.RPS.PAPER:
                            {
                                return "Win";
                            }
                        case RockPaperScissorsEnum.RPS.ROCK:
                            {
                                return "Lose";
                            }
                        default:
                            {
                                return "Draw";
                            }
                    }
                }
        }
        return "You cheat me ?";
    }

    IEnumerator ClearSelectedFromBoth()
    {
        yield return new WaitForSeconds(2);
        opponent.ClearSelectedChoice();
        player.ClearSelectedChoice();
        EnableButtons();
    }
}
