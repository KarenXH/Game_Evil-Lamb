using UnityEngine;

public class BossBeAttack : MonoBehaviour
{
    [SerializeField] protected AudioSource audioS;
    [SerializeField] protected GameObject uiBossHeal;

    [SerializeField] protected GameObject bossSpi;

    private void LateUpdate()
    {
        this.OffBoxColi();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("PlayerAttack"))
        {
            BossHealthManager.currentBossHealth -= 1;
            audioS.Play();
        }
    }

    protected virtual void OffBoxColi()
    {
        if (BossHealthManager.currentBossHealth == 0 && uiBossHeal.activeSelf==true)
        {
            bossSpi.GetComponent<Animator>().SetBool("dead", true);
            this.gameObject.SetActive(false);
        }
    }
}
