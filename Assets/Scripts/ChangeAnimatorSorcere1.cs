using System.Collections;
using UnityEngine;

public class ChangeAnimatorSorcere1 : MonoBehaviour
{
    private static ChangeAnimatorSorcere1 instance;
    public static ChangeAnimatorSorcere1 Instance { get => instance; }
    [SerializeField] public bool inAttack = false;
    public bool InAttack { get => inAttack; }

    [SerializeField] protected Animator anim;
    [SerializeField] protected Vector3 oldEnemyPos;

    [SerializeField] protected Transform player;
    [SerializeField] protected Transform bigParentObj;
    [SerializeField] protected float dist;
    [SerializeField] protected float howCloseRangePre;
    [SerializeField] protected float howCloseRangeAtk;

    [SerializeField] protected GameObject boxAttack;
    bool check2 = false;

    
    private void Awake()
    {
        ChangeAnimatorSorcere1.instance = this;
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        oldEnemyPos = gameObject.transform.position;
    }

    void Update()
    {
        this.GetDistanceRange();
        this.ChangeAnim();
    }

    protected virtual void GetDistanceRange()
    {
        dist = Vector3.Distance(player.position, bigParentObj.position);
    }
    protected virtual void ChangeAnim()
    {
        bool s = CheckPlayerInRange.Instance.inRange;

        if (dist > howCloseRangeAtk && dist <= howCloseRangePre && check2 == false )
        {
            anim.SetBool("idle", false);
            anim.SetBool("preattack", true);
            check2 = true;
        }
        if (dist <= howCloseRangeAtk && s == true && check2==true)
        {
            anim.SetBool("idle", false);
            anim.SetBool("preattack", false);
            anim.SetBool("attack", true);
            
            boxAttack.SetActive(true);
            inAttack = true;
            StartCoroutine(EndAnim());            
        }
    }
    IEnumerator EndAnim()
    {        
        yield return new WaitForSeconds(1);
        anim.SetBool("idle", true);
        anim.SetBool("attack", false);
        boxAttack.SetActive(false);        
        inAttack = false;        
        check2 = false;        
    }
}
