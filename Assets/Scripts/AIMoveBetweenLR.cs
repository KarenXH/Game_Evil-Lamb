using UnityEngine;

public class AIMoveBetweenLR : MonoBehaviour
{
    [SerializeField] protected GameObject[] waypoints;
    [SerializeField] protected int currentWayPointIndex = 0;
    [SerializeField] protected float speed;
    [SerializeField] protected GameObject playerGObj;
    [SerializeField] protected GameObject enemyModel;
    [SerializeField] protected bool checkFace = false;
    [SerializeField] protected Vector3 scale;
    [SerializeField] protected float awakePos;

    private void Awake()
    {
        awakePos = enemyModel.transform.position.x;
    }
    void Update()
    {
        this.MoveBetweenPoints();
    }
    protected virtual void MoveBetweenPoints()
    {
        this.AILookingWhenBackWayPoints();
        scale = enemyModel.transform.localScale;
        if (Vector2.Distance(waypoints[currentWayPointIndex].transform.position, transform.position) < 0.1f)
        {
            currentWayPointIndex++;
            scale.x = Mathf.Abs(scale.x) * -1;
            checkFace = true;
            if (currentWayPointIndex >= waypoints.Length)
            {
                currentWayPointIndex = 0;
                scale.x = Mathf.Abs(scale.x) * 1;
                checkFace = false;
            }
        }
        enemyModel.transform.localScale = scale;
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWayPointIndex].transform.position, Time.deltaTime * speed);
    }
    protected virtual void AILookingWhenBackWayPoints()
    {

        if (checkFace == true && scale.x < 0)
        {
            scale.x = Mathf.Abs(scale.x) * -1;
            enemyModel.transform.localScale = scale;
        }
        else if(checkFace == false && scale.x > 0)
        {
            scale.x = Mathf.Abs(scale.x) * 1;
            enemyModel.transform.localScale = scale;
        }

    }
}
