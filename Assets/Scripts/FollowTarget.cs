using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] protected Transform target;
    void Update()
    {
        this.FollowTheTarget();
    }
    protected virtual void FollowTheTarget()
    {
        transform.position = target.position;
    }
}
