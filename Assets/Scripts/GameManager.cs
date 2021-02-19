using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 0f;
    public GameObject gameOverUI;
    public int animalsKilled = 0;
    public Text scoreText;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            gameOverUI.SetActive(true);
            Invoke("Restart", restartDelay);
            animalsKilled = 0;
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void incrementScore()
    {
        animalsKilled++;
        Debug.Log(animalsKilled / 2);
        scoreText.text = animalsKilled.ToString();
    }
}
