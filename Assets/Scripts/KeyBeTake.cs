using UnityEngine;

public class KeyBeTake : MonoBehaviour
{
    [SerializeField] protected GameObject keyDestroy;
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            int s = PlayerPrefs.GetInt("key_count");
            s++;
            PlayerPrefs.SetInt("key_count", s);    
            keyDestroy.SetActive(false);
            PlayerPrefs.Save();
        }
    }
}
