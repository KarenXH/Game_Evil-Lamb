using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    public Transform target;
    public float smooth;
    public bool turnOnOF;

    private float time = 0f;
    private float timeDelay = 3f;


    void Start()
    {
        turnOnOF = false;
        
    }
    // Update is called once per frame
    void Update()
    {
        this.MoveToTarget();  
    }
    protected virtual void MoveToTarget()
    {
        if (time <= 5)
        {
            time = time + 1f * Time.deltaTime;
        }

        if (time >= timeDelay)
        {
            if (Input.anyKey)
            {
                turnOnOF = true;
            }
            if (turnOnOF)
            {
                transform.position = Vector3.Lerp(transform.position, target.position, smooth * Time.deltaTime);
            }
        }
    }
}
