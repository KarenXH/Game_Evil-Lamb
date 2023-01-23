using UnityEngine;

public class DeathEnemyAnim : MonoBehaviour
{
    [SerializeField] protected GameObject parentGameObj;
    protected virtual void TurnOffAnim()
    {
        parentGameObj.SetActive(false);
        //Destroy(parentGameObj); //same
    }
 
}
