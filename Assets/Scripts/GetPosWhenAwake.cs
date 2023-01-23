using UnityEngine;

public class GetPosWhenAwake : MonoBehaviour
{
    [SerializeField] protected Transform target;
  
    void Awake()
    {
        this.GetPosTarget();
    }
    protected virtual void GetPosTarget()
    {
        transform.position = target.position;
    }
}
