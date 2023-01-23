using UnityEngine;

public class OnRangeChainAttack : MonoBehaviour
{
    [SerializeField] protected GameObject boxColiChain;
    
    protected virtual void OnBox()
    {
        boxColiChain.SetActive(true);
    }
    protected virtual void OffBox()
    {
        boxColiChain.SetActive(false);
    }
}
