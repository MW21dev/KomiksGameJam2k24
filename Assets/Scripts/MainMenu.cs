using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenu : MonoBehaviour
{
    public GameObject creditsImage;

    private void Start()
    {
        creditsImage.SetActive(false);
    }
    public void GameStart()
    {
        SceneManager.LoadScene( 0 , LoadSceneMode.Single);
    }

    public void CreditsImage()
    {
        creditsImage.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

}
