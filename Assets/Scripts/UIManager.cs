using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text youWon;
    [SerializeField] private Text GameOver;

    public void WinScreen()
    {
       youWon.text = "YOU WIN!!!";
        GameOver.text = "";
    }

    public void LoseScreen()
    {
        youWon.text = "";
        GameOver.text = "GAME OVER";
    }
}