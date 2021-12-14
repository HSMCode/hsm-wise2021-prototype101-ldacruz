using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreTimer : MonoBehaviour
{
    // This script serves as score counter and countdown timer.
    // It needs the below named and UI components, make sure to rename either your UI GameObjects or the names in the script. 
    // !! This example uses the standard Unity UI text. IF you want to use TextMeshPro instead,
    // the GetComponent method and variable types need to be changed to:
    //   "TextMeshProUGUI" instead of "Text" (for variable types)
    //   ".GetComponent<TextMeshProUGUI>();" instead of ".GetComponent<Text>();"
    //   "using TMPro;" library needs to be added at the very top instead of the UI library "using UnityEngine.UI;"
    
    // variable for the UI parent elements for enabling and disabling
    private GameObject _gameUI;
    private GameObject _gameOverUI;

    // bool variables for logic
    public bool gameOver;
    public bool useTimer; 
    private bool gameWon;
    private bool gameLost;
    
    // variables for Score
    private Text scoreUI;
    public string scoreText = "Score: ";
    private int currentScore = 0;
    public int addScore = 1;
    public int winScore = 3;
    
    // variables for Timer
    private Text timerUI;
    public string countdownText = "Countdown: ";
    public float countRemaining = 10f;
    private bool countingDown;

    // variables for Result UI Canvas
    private Text resultUI;
    public string resultLost = "You lost!";
    public string resultWin = "You won!";
    
    
    void Start()
    {
        // set time scale to 1 (this makes sure to resume the normal play speed after each scene reload
        Time.timeScale = 1.0f;

        // get the UI parent objects to enable and disable them
        _gameUI = GameObject.Find("Game");
        _gameOverUI = GameObject.Find("GameOver");
        
        // get and save the UI text components 
        scoreUI = GameObject.Find("Score").GetComponent<Text>();
        timerUI = GameObject.Find("Timer").GetComponent<Text>();
        resultUI = GameObject.Find("Result").GetComponent<Text>();

        // disable the game over screen
        _gameUI.SetActive(true);
        _gameOverUI.SetActive(false);

        // set the countdown variable to true
        countingDown = true;
    }

    void Update()
    {
        // start the countdown timer
        CountdownTimer();
    }


    // this method handles the score update (as long as the game is not over yet) and calls the check game over method
    public void UpdateMyScore()
    {
        if (!gameOver)
        {
            currentScore += addScore;
            scoreUI.text = scoreText + currentScore.ToString();

            CheckGameOver();
        }
    }
    
    // this method counts down in seconds as long as the timer usage is allowed and timer countdown is true
    // once the timer is finished (at zero) the game over method is called, to check for the end result and
    // the counter is set to zero. 
    private void CountdownTimer()
    {
        if (countingDown && useTimer)
        {
            if (countRemaining > 0)
            {
                countRemaining -= Time.deltaTime;
                timerUI.text = countdownText + Mathf.Round(countRemaining).ToString();
            }
            else
            {
                countRemaining = 0;
                timerUI.text = countdownText + countRemaining.ToString();
                countingDown = false;
                
                CheckGameOver();
            }
        }
    }
    

    // the game over method checks if the win condition is already meet or
    // when the time has run out, if the game is lost or won
    // both game over states call the game over coroutine to wait 1 second before the result UI is shown
    private void CheckGameOver()
    {
        // GameOver WIN
        if (currentScore >= winScore)
        {
            gameOver = true;
            gameWon = true;

            StartCoroutine(GameOver());
        } 
        // GameOver LOST
        else if (currentScore <= winScore && !countingDown)
        {
            gameOver = true;
            gameLost = true;

            StartCoroutine(GameOver());
        }
    }

    // GameOver method waits and then shows the result UI either
    // with text Win displayed in green (Using simple color reference) or text for Losing in red (using RBGA color reference). 
    // GameOver UI is set active with Restart button. 
    private IEnumerator GameOver()
    {
        yield return new WaitForSeconds(1f);

        if (gameOver)
        {
            Time.timeScale = 0f;

            if (gameWon)
            {
                resultUI.text = resultWin;
                resultUI.color = Color.green;
            }
            else if (gameLost)
            {
                resultUI.text = resultLost;
                resultUI.color = new Color32(255,0,0,255);
            }
            
            _gameUI.SetActive(false);
            _gameOverUI.SetActive(true);
        }
    }

}

