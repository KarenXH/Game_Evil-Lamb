using UnityEngine;

public class CheckPlayerInSideMap : MonoBehaviour
{
    [SerializeField] protected GameObject boxColiTruoc;
    [SerializeField] protected GameObject boxColiSau;
    [SerializeField] protected GameObject meshTruoc;
    [SerializeField] protected GameObject meshSau;
    [SerializeField] protected GameObject wall_1;
    [SerializeField] protected GameObject wall_2;
    [SerializeField] protected GameObject wall_3;
    [SerializeField] protected GameObject wall_4;

    [SerializeField] protected bool checkEnemy=false;

    [SerializeField] public GameObject[] respawnsEnemy;

    private void Update()
    {
        this.CountEnemy();
        this.CheckEnemyAlive();
        this.BlockPlayer();
        this.FreePlayer();
    }
    protected virtual void CountEnemy()
    {
        respawnsEnemy = GameObject.FindGameObjectsWithTag("Enemy");
    }
    protected virtual void CheckEnemyAlive()
    {
        if(respawnsEnemy.Length == 0)
        {
            checkEnemy = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
                checkEnemy = true;                      
        }
    }
    protected virtual void BlockPlayer()
    {
        if (checkEnemy == true)
        {
            boxColiTruoc.SetActive(true);
            boxColiSau.SetActive(true);
            meshTruoc.SetActive(true);
            meshSau.SetActive(true);

            wall_1.SetActive(false);
            wall_2.SetActive(false);
            wall_3.SetActive(false);
            wall_4.SetActive(false);
        }
    }
    protected virtual void FreePlayer()
    {
        if (checkEnemy == false)
        {
            wall_1.SetActive(true);
            wall_2.SetActive(true);
            wall_3.SetActive(true);
            wall_4.SetActive(true);

            meshTruoc.SetActive(false);
            meshSau.SetActive(false);
            boxColiTruoc.SetActive(false);
            boxColiSau.SetActive(false);
        }
    }
}