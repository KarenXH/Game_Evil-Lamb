using UnityEngine;

public class CheckAttackOfPlayer : MonoBehaviour
{
    [SerializeField] protected GameObject parentGameOBJ;
    [SerializeField] protected int hpEnemy =2;
    [SerializeField] protected GameObject deathAnim;
    [SerializeField] protected AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("PlayerAttack"))
        {
            audioSource.Play();
            hpEnemy -= 1;
        }
    }
    private void Update()
    {
        this.DestroyEnemy();        
    }
    protected virtual void DestroyEnemy()
    {
        if (hpEnemy <= 0)
        {
            if (deathAnim != null)
            {
                deathAnim.SetActive(true);
            }
            
            parentGameOBJ.SetActive(false);            
        }
    }
}
