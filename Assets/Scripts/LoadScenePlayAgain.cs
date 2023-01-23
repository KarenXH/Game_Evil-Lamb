using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenePlayAgain : MonoBehaviour
{
    [SerializeField] protected int indexScene =7;
    void LateUpdate()
    {
        this.CheckPlayerDeath();
    }
    protected virtual void CheckPlayerDeath()
    {
        if (HealthMangaer.CurrentHealth == 0)
        {
            SceneManager.LoadScene(indexScene);
        }
    }
    
}
