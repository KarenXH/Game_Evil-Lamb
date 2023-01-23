using UnityEngine;

public class TurnOnTutorial : MonoBehaviour
{
    [SerializeField] protected GameObject tutorial;


    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            tutorial.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tutorial.SetActive(false);
        }
    }
}
