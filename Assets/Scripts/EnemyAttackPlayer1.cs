using UnityEngine;

public class EnemyAttackPlayer1 : MonoBehaviour
{
    [SerializeField] protected Transform player;
    [SerializeField] protected Transform bigParentObj;
    [SerializeField] protected float dist;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float howClose;
    void Update()
    {
        this.GetDistance();
        this.MoveToPlayer();
    }
    protected virtual void GetDistance()
    {
        dist = Vector3.Distance(player.position, bigParentObj.position);
    }
    protected virtual void MoveToPlayer()
    {
        if (dist <= howClose)
        {
            transform.parent.position = Vector3.Lerp(transform.parent.position, player.position, Time.deltaTime * moveSpeed);
        }
    }
}
