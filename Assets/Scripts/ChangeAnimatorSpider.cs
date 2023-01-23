using UnityEngine;

public class ChangeAnimatorSpider : MonoBehaviour
{
    [SerializeField] protected Animator anim;
    [SerializeField] protected Vector3 oldEnemyPos;

    void Start()
    {
        anim = GetComponent<Animator>();
        oldEnemyPos = gameObject.transform.position;
    }

    void Update()
    {
        this.CheckSpiderRun();
    }
    protected virtual void CheckSpiderRun()
    {
        if (oldEnemyPos != gameObject.transform.position)
        {
            oldEnemyPos = gameObject.transform.position;
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
        }
    }
}
