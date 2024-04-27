using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausemenu.activeSelf)
            {
                Unpause();
            }
            else
            {
                Pause();
            }
        }

    }
    private void Pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Unpause()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ExiToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene( "MainMenu", LoadSceneMode.Single);
    }
}
