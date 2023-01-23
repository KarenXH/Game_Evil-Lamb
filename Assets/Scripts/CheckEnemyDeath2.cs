using UnityEngine;

public class CheckEnemyDeath2 : MonoBehaviour
{
    [SerializeField] protected GameObject enemy;
    [SerializeField] protected GameObject keyFall2;
    [SerializeField] protected bool checkKeyFall = false;
    private void Update()
    {
        this.EnemyDead();
    }
    protected virtual void EnemyDead()
    {
        if (enemy.activeSelf == false && checkKeyFall == false)
        {
            this.KeyFalls();
        }
    }
    protected virtual void KeyFalls()
    {
        if (KeyManager.Instance.KeyShow == 2)
        {
            checkKeyFall = true;
            keyFall2.SetActive(true);
        }
    }
}
