using System.Collections;
using UnityEngine;

public class CheckPlayerInRange : MonoBehaviour
{
    private static CheckPlayerInRange instance;
    public static CheckPlayerInRange Instance { get => instance; }
    [SerializeField] public bool inRange = false;
    protected bool InRange { get => inRange;}

    

    private void Awake()
    {
        CheckPlayerInRange.instance = this;
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            inRange = true;
            StartCoroutine(WaitAnim());
        }
        
    }
    IEnumerator WaitAnim() { yield return new WaitForSeconds(1); inRange = false; }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inRange = false;
        }
    }
}
