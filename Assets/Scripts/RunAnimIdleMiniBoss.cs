using System.Collections;
using UnityEngine;

public class RunAnimIdleMiniBoss : MonoBehaviour
{
    [SerializeField] protected GameObject spawn;
    [SerializeField] protected GameObject follow;

    [SerializeField] protected bool bossDie = false;
  
    private void LateUpdate()
    {
        this.CheckHpMiniBoss();        
    }
    protected virtual void RunIdleMiniBoss()
    {
        this.gameObject.GetComponent<Animator>().SetBool("idle", true);
        follow.SetActive(true);
    }
    protected virtual void CheckHpMiniBoss()
    {
        if (CheckAttackOfPlayer2.Instance.HpEnemy <= 0 &&bossDie==false)
        {
            this.RunDieMiniBoss();
        }
    }
    protected virtual void RunDieMiniBoss()
    {
        bossDie =true;
        follow.SetActive(false);
        StartCoroutine(WaitDoneAnimDeath());
        
    }
    IEnumerator WaitDoneAnimDeath()
    {
        yield return new WaitForSeconds((float)0.1);
        this.gameObject.GetComponent<Animator>().SetBool("idle", false);
        
        CheckAttackOfPlayer2.Instance.HpEnemy = 3;
        bossDie = false;
        spawn.SetActive(false);
    }

}
