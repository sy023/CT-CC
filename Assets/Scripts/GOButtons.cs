using UnityEngine;
using UnityEngine.SceneManagement;

public class GOButtons : MonoBehaviour
{
    public LevelLoader levelLoader;

    public void Home()
    {
        levelLoader.LoadScene(2);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
