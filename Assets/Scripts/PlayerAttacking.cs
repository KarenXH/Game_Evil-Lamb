using System.Collections;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
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

    [SerializeField] protected bool doneCooldown = false;

    private void Update()
    {
        this.Attacking();
    }

    protected virtual void Attacking()
    {
        if (Input.GetMouseButtonDown(0) && doneCooldown == false)
        {
            if (Time.timeScale == 0) return;
            doneCooldown = true;
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
            StartCoroutine(CooldownAttack());

        }
        if (modelAttack.activeSelf==false)
        {
            if (Time.timeScale == 0) return;
            modelAttack.SetActive(false);
            modelMovement.SetActive(true);
            playerMovement.SetActive(true);
            flipModel.SetActive(true);
        }
    }
    IEnumerator CooldownAttack()
    {
        yield return new WaitForSeconds((float)0.7);
        doneCooldown = false;
    }


}
