using System.Collections;
using UnityEngine;

public class PlayerCheckEnemyAttack : MonoBehaviour
{
    [SerializeField] protected AudioSource audioSource;
    [SerializeField] protected bool isTouch = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("EnemyAttack2"))
        {
            if (isTouch == false)
            {
                isTouch = true;
                StartCoroutine(OnShotRoutine2());
            }
        }
    }
    IEnumerator OnShotRoutine2()
    {
        HealthMangaer.CurrentHealth -= 2;
        audioSource.Play();
        yield return new WaitForSeconds(2);

        isTouch = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("EnemyAttack"))
        {
            if(isTouch ==false)
            {
                isTouch = true;
                StartCoroutine(OnShotRoutine());
            }        
        }        
    }        
    IEnumerator OnShotRoutine()
    {
        HealthMangaer.CurrentHealth -= 1;
        audioSource.Play();
        yield return new WaitForSeconds(3);
        
        isTouch = false;        
    }
}
