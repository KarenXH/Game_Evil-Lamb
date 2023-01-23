using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioMixer mainMixer;

    public void SetVolume(float volume)
    {
        mainMixer.SetFloat("volume", volume);
    }
    public virtual void GoToSettingsMenu()
    {   
        Time.timeScale = 0;
        SceneManager.LoadScene("SettingsMenu");     
    }
    public virtual void GoToMainMenu()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
    public void QuitToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
