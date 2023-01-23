using UnityEngine;

public class EnemyLookingPlayer : MonoBehaviour
{
    [SerializeField] protected GameObject player;
    [SerializeField] protected GameObject enemy;    
    void Update()
    {
        this.AILooking();
    }

    protected virtual void AILooking()
    {
        Vector3 scale = enemy.transform.localScale;

        if (player.transform.position.x > enemy.transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x) * -1;
        }
        else
        {
            scale.x = Mathf.Abs(scale.x);
        }
        enemy.transform.localScale = scale;
    }
}
