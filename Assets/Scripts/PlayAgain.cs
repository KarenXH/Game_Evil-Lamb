using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    public void LoadLevel0()
    {
        Time.timeScale = 1;
        StartCoroutine(LoadLevel(2));
    }
    IEnumerator LoadLevel(int levelIndext)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndext);
    }
}
