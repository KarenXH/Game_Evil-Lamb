using UnityEngine;

public class TurnOffModelPlayerAttack : MonoBehaviour
{
    protected virtual void TurnOffAnim()
    {
        this.gameObject.SetActive(false);
        
    }
}
