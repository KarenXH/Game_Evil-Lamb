using UnityEngine;

public class CloseTarget : MonoBehaviour
{
    [SerializeField] protected GameObject chainAtk;

    protected virtual void CloseAnimTarget()
    {
        this.gameObject.SetActive(false);
    }
    protected virtual void OnChainAttack()
    {
        chainAtk.SetActive(true);
    }
    protected virtual void OffChainAttack()
    {
        chainAtk.SetActive(false);
    }
}
