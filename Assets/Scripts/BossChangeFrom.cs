using UnityEngine;

public class BossChangeFrom : MonoBehaviour
{
    [SerializeField] protected GameObject change1;
    [SerializeField] protected GameObject change2;
    [SerializeField] protected GameObject change3;
    [SerializeField] protected GameObject change4;
    [SerializeField] protected GameObject bossNor;

    protected virtual void RunAnimChangeFrom()
    {
        change1.SetActive(true);
        change2.SetActive(true);
        change3.SetActive(true);
        change4.SetActive(true);
        bossNor.SetActive(false);
    }
}
