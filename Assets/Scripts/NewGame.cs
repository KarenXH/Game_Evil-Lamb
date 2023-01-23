using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    [SerializeField] public static string key = "key_count";
    public virtual void NewDataGame()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt(key, 0);
        LoadNextLevelNewGame();
    }
    public Animator transition;

    public float transitionTime = 1f;

    public void LoadNextLevelNewGame()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndext)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndext);
    }
}
