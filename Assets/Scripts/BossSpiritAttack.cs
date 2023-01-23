using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BossSpiritAttack : MonoBehaviour
{
    [SerializeField] protected GameObject bossSpirit;

    [SerializeField] protected GameObject player;
    [SerializeField] protected Vector3 posPlayer;
    [SerializeField] protected GameObject target;

    [SerializeField] protected Image bossHealthBar;
    void Start()
    {
        StartCoroutine(ChangeAnimSpirit());
    }

    private void Update()
    {
        this.GetPosPlayer();
        this.StopSpiritAttack();
    }
    IEnumerator ChangeAnimSpirit()
    {
        yield return new WaitForSeconds((float)1);
        bossSpirit.GetComponent<Animator>().SetBool("attack", true);              
        target.SetActive(true);
        target.transform.position = posPlayer;
        yield return new WaitForSeconds((float)4);
        StartCoroutine(ChangeAnimSpirit());
    }
    protected virtual void GetPosPlayer()
    {
        posPlayer = player.transform.position;
    }
    protected virtual void StopSpiritAttack()
    {
        if (bossHealthBar.fillAmount == 0)
        {
            bossSpirit.GetComponent<Animator>().SetBool("attack", false);
            target.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
