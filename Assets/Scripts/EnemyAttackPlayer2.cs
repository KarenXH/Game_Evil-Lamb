using UnityEngine;

public class EnemyAttackPlayer2 : MonoBehaviour
{
    [SerializeField] protected Transform player;
    [SerializeField] protected Transform bigParentObj;
    [SerializeField] protected float dist;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float howClose;
    [SerializeField] protected GameObject aILooking;

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
        if(dist <= howClose)
        {
            aILooking.SetActive(true);
            bigParentObj.GetComponent<AIMoveBetweenLR>().enabled = false;            
            transform.parent.position = Vector3.Lerp(transform.parent.position, player.position, Time.deltaTime * moveSpeed);
        }
        else if(dist > howClose)
        {
            aILooking.SetActive(false);
            bigParentObj.GetComponent<AIMoveBetweenLR>().enabled = true;            
        }
    }
}
