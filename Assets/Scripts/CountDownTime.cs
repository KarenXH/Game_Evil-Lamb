using UnityEngine;
using UnityEngine.SceneManagement;

public class CountDownTime : MonoBehaviour
{
    public float time;
    void Update()
    {
        this.CountTimeToNextScene();
    }
    protected virtual void CountTimeToNextScene()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
