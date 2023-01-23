using System.Collections;
using UnityEngine;

public class DummyCheckBeAttack : MonoBehaviour
{
    
    [SerializeField] protected AudioSource audioSource;
    [SerializeField] protected GameObject warning;
    [SerializeField] protected int keyOfDummy;
    [SerializeField] protected GameObject keyFall;

    [SerializeField] public static string firstquest = "first_quest";
    [SerializeField] public static string checktquest = "check_quest";
    private void Awake()
    {
        string t = PlayerPrefs.GetString(checktquest);
        if (t != "b" && t!="c")
        {
            PlayerPrefs.SetInt(firstquest, 1);
            return;
        }
        PlayerPrefs.SetInt(firstquest, 0);
    }
    private void Start()
    {
        this.PlayIdle();
        keyOfDummy = PlayerPrefs.GetInt("first_quest");
    }
    private void Update()
    {
        this.CheckWarning();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("PlayerAttack"))
        {
            audioSource.Play();
            if(keyOfDummy == 1)
            {
                keyOfDummy -= 1;
                PlayerPrefs.SetInt(firstquest, 0);
                PlayerPrefs.SetString(checktquest,"b");
                PlayerPrefs.Save();

                keyFall.SetActive(true);
            }            
            this.PlayBeAttack();            
        }
    }
    protected virtual void PlayIdle()
    {
        gameObject.GetComponent<Animator>().Play("idledummy");
    }
    protected virtual void PlayBeAttack()
    {
        gameObject.GetComponent<Animator>().Play("attackdummy");
        StartCoroutine(StopPlayBeAttack());
    }

    IEnumerator StopPlayBeAttack()
    {
        yield return new WaitForSeconds((float)0.5);
        this.PlayIdle();
    }
    protected virtual void CheckWarning()
    {
        if (keyOfDummy == 0)
        { warning.SetActive(false); }
    }

    private void OnApplicationQuit()
    {
        if (PlayerPrefs.GetString(checktquest) == "b" && PlayerPrefs.GetInt("key_count") ==0)
        {
            PlayerPrefs.SetInt("key_count", 1);
            PlayerPrefs.SetString(checktquest, "c");
            PlayerPrefs.Save();
        }
    }

}
