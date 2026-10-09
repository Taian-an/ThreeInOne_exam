using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;
    }

    public void PlayDriving() { SceneManager.LoadScene("Prototype 1"); }
    public void PlayFlying()  { SceneManager.LoadScene("Challenge 1"); }
    public void PlaySumo()    { SceneManager.LoadScene("Challenge 4"); }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}