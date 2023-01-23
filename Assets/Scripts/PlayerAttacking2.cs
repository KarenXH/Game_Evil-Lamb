using System.Collections;
using UnityEngine;

public class PlayerAttacking2 : MonoBehaviour
{
    [SerializeField] protected GameObject modelAttack;    
    [SerializeField] protected GameObject modelRunBack;
    [SerializeField] protected GameObject modelIdle;
    [SerializeField] protected GameObject modelIdleBack;
    [SerializeField] protected GameObject modelRunFront;
    [SerializeField] protected GameObject modelRunSide;
    [SerializeField] protected GameObject modelRunSideFront;
    [SerializeField] protected GameObject modelRunSideBack;

    [SerializeField] protected GameObject playerMovement;
    [SerializeField] protected GameObject flipModel;
    [SerializeField] protected GameObject modelMovement;

    [SerializeField] protected bool doneCooldown=true;

    private void Awake()
    {
        StartCoroutine(CooldownAttack2());
    }
    private void Update()
    {
        if (StopPlayerForSec.Instance.IsStopping == true) {
                 return; }
        this.Attacking();
    }

    protected virtual void Attacking()
    {
        if (InputManager2.Instance.IsAttacking == 1 && doneCooldown==true && StopPlayerForSec.Instance.IsStopping == false)
        {
            if (Time.timeScale == 0) return;
            doneCooldown = false;
            modelAttack.SetActive(true);

            modelRunSideBack.SetActive(false);
            modelRunSideFront.SetActive(false);
            modelRunSide.SetActive(false);
            modelRunFront.SetActive(false);
            modelIdle.SetActive(false);
            modelIdleBack.SetActive(false);
            modelRunBack.SetActive(false);

            modelMovement.SetActive(false);
            playerMovement.SetActive(false);
            flipModel.SetActive(false);
            StartCoroutine(CooldownAttack2());
        }
    }

    IEnumerator CooldownAttack2()
    {
        yield return new WaitForSeconds((float)0.7);
        doneCooldown = true;
    }

}
