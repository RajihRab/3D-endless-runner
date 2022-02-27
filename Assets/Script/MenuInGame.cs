using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuInGame : MonoBehaviour
{
   public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuLevel()
    {
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }
}