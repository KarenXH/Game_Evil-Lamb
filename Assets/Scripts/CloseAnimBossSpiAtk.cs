using UnityEngine;

public class CloseAnimBossSpiAtk : MonoBehaviour
{
    [SerializeField] protected GameObject parentBoss;
    [SerializeField] protected GameObject canvasHealth;

    protected virtual void BackToAnimIdle()
    {
        this.gameObject.GetComponent<Animator>().SetBool("attack", false);
    }
    
    protected virtual void BossDie()
    {
        canvasHealth.SetActive(false);
        parentBoss.SetActive(false);
    }
}
