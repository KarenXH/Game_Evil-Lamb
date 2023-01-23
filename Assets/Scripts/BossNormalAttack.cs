using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BossNormalAttack : MonoBehaviour
{
    [SerializeField] protected GameObject uiBossHealth;
    [SerializeField] protected GameObject bossNormal;
    [SerializeField] protected bool checkBossNormalAtk=false;

    [SerializeField] protected GameObject spawnMini1;

    [SerializeField] protected Image bossHealthBar;

    void Update()
    {
        this.RunBoss();
    }
    protected virtual void RunBoss()
    {
        if (uiBossHealth.activeSelf == true && checkBossNormalAtk == false)
        {
            checkBossNormalAtk = true;
            StartCoroutine(ChangeAnimNormal());
        }
        this.StopNormalAttack();        
    }
    IEnumerator ChangeAnimNormal()
    {
        bossNormal.GetComponent<Animator>().SetBool("useSkill1", true);
        spawnMini1.SetActive(true);
        yield return new WaitForSeconds((float)1.8);        
        bossNormal.GetComponent<Animator>().SetBool("useSkill1", false);
        yield return new WaitForSeconds((float)5.2);
        StartCoroutine(ChangeAnimNormal());
    }

    protected virtual void StopNormalAttack()
    {
        if (bossHealthBar.fillAmount == 0.5)
        {
            spawnMini1.SetActive(false);
            bossNormal.GetComponent<Animator>().SetBool("useSkill1", false);
            bossNormal.GetComponent<Animator>().SetBool("changefrom", true);
            this.gameObject.SetActive(false);
        }
    }



}
