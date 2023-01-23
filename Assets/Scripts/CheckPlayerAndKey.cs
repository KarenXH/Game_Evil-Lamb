using UnityEngine;

public class CheckPlayerAndKey : MonoBehaviour
{
    [SerializeField] protected GameObject door1;
    [SerializeField] protected GameObject door2;
    [SerializeField] protected GameObject door3;
    [SerializeField] protected GameObject awakedoor1;
    [SerializeField] protected GameObject awakedoor2;
    [SerializeField] protected GameObject awakedoor3;
    [SerializeField] protected AudioSource audioSource;
    [SerializeField] protected GameObject showMes;

    private void Awake()
    {
        this.AutoOpenDoor();
    }

    protected virtual void AutoOpenDoor()
    {
        int s = PlayerPrefs.GetInt(SavePlayerPrefs.key);
        if (s == 3)
        {
            awakedoor3.GetComponent<Animator>().enabled = true;
            door3.GetComponent<BoxCollider>().enabled = true;
            awakedoor2.GetComponent<Animator>().enabled = true;
            door2.GetComponent<BoxCollider>().enabled = true;
            awakedoor1.GetComponent<Animator>().enabled = true;
            door1.GetComponent<BoxCollider>().enabled = true;
            return;
        }
        else if (s == 2)
        {
            awakedoor2.GetComponent<Animator>().enabled = true;
            door2.GetComponent<BoxCollider>().enabled = true;
            awakedoor1.GetComponent<Animator>().enabled = true;
            door1.GetComponent<BoxCollider>().enabled = true;
            return;
        }
        else if (s == 1)
        {
            awakedoor1.GetComponent<Animator>().enabled = true;
            door1.GetComponent<BoxCollider>().enabled = true;
            return;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            int n = KeyManager.Instance.KeyShow;
            if ( n == 3)
            {
                if (awakedoor3.GetComponent<Animator>().enabled == false && door3.GetComponent<BoxCollider>().enabled == false)
                {
                    audioSource.Play();
                }
                awakedoor3.GetComponent<Animator>().enabled = true;
                door3.GetComponent<BoxCollider>().enabled = true;
            }
            if (n == 2)
            {
                if (awakedoor2.GetComponent<Animator>().enabled == false && door2.GetComponent<BoxCollider>().enabled == false)
                {
                    audioSource.Play();
                }                
                awakedoor2.GetComponent<Animator>().enabled = true;
                door2.GetComponent<BoxCollider>().enabled = true;
            }
            if (n == 1)
            {
                if (awakedoor1.GetComponent<Animator>().enabled == false && door1.GetComponent<BoxCollider>().enabled == false)
                {
                    audioSource.Play();
                }
                awakedoor1.GetComponent<Animator>().enabled = true;
                door1.GetComponent<BoxCollider>().enabled = true;
            }         
                 
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            showMes.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            showMes.SetActive(false);
        }
    }

}
