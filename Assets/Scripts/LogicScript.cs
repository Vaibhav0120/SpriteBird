using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Add Score")]

    public void addScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
