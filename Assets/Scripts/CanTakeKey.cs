using System.Collections;
using UnityEngine;

public class CanTakeKey : MonoBehaviour
{
    [SerializeField] protected GameObject boxColi;

 
    protected virtual void OpenBoxColi_1()
    {
        StartCoroutine(WaitSecTakeKey());
    }
    IEnumerator WaitSecTakeKey()
    {
        yield return new WaitForSeconds((float)1);
        boxColi.SetActive(true);
    }
}
