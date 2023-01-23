using UnityEngine;

public class CheckEnemyDeath : MonoBehaviour
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
        if (KeyManager.Instance.KeyShow == 1)
        {
            checkKeyFall = true;
            keyFall2.SetActive(true);
        }
    }
}
