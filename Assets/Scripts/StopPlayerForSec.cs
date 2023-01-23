using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StopPlayerForSec : MonoBehaviour
{
    private static StopPlayerForSec instance;
    [SerializeField] protected GameObject inputManager;
    [SerializeField] protected GameObject flipModel;
    [SerializeField] protected GameObject onModelMovement;
    [SerializeField] protected GameObject playerAttacking;

    [SerializeField] protected bool checkStopPlayer=false;
    [SerializeField] protected Image bossHealth;
    [SerializeField] private bool isStopping = false;
    public bool IsStopping { get => isStopping;}
    public static StopPlayerForSec Instance { get => instance; }

    private void Awake()
    {
        StopPlayerForSec.instance = this;   
    }
    void Update()
    {
        this.StopPlayer();
    }
    protected virtual void StopPlayer()
    {
        
        if (bossHealth.fillAmount == 0.5 && checkStopPlayer==false)
        {
            checkStopPlayer = true;
            isStopping = true;
            StartCoroutine(PlayPlayer());
        }
    }

    IEnumerator PlayPlayer()
    {
        inputManager.SetActive(false);
        yield return new WaitForSeconds((float)4);
        isStopping = false;

        inputManager.SetActive(true);
        playerAttacking.SetActive(true);
        flipModel.SetActive(true);
        onModelMovement.SetActive(true);
    
    }
}
