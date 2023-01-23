using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoadGamePlay : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;
    public int indexScene;
       
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LoadNextLevel();
        }
        
    }
    public void LoadNextLevel()
    {
        Time.timeScale = 1;
        StartCoroutine(LoadLevel(indexScene));
    }
    IEnumerator LoadLevel(int levelIndext)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndext);
    }

}
