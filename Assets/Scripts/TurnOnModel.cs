using UnityEngine;

public class TurnOnModel : MonoBehaviour
{
    [SerializeField] protected GameObject modelRunBack;
    [SerializeField] protected GameObject modelIdle;
    [SerializeField] protected GameObject modelIdleBack;
    [SerializeField] protected GameObject modelRunFront;
    [SerializeField] protected GameObject modelRunSide;
    [SerializeField] protected GameObject modelRunSideFront;
    [SerializeField] protected GameObject modelRunSideBack;
    [SerializeField] protected ParticleSystem dust;
    [SerializeField] protected GameObject audioObj;

    private float direcX;
    private float direcZ;
    private bool checkHistory = false;

    void Update()
    {
        this.HistoryKeyDown();
        this.CheckTurnOnModel();       
    }
    protected virtual void CheckTurnOnModel()
    {
        if (Time.timeScale == 0) return;
        direcZ = Input.GetAxis("Vertical");
        direcX = Input.GetAxis("Horizontal");
        this.RunNormalAnimation();
        this.CheckRun();
    }
 
    protected virtual void CheckRun()
    {
        if(direcX!=0 || direcZ != 0)
        {
            audioObj.SetActive(true);
        }else if(direcX == 0 && direcZ == 0)
        {
            audioObj.SetActive(false);
        }
    }
    protected virtual void RunNormalAnimation()
    {
        if (direcZ > 0 && direcX ==0)
        {
            modelRunSide.SetActive(false);
            modelRunFront.SetActive(false);
            modelIdle.SetActive(false);
            modelIdleBack.SetActive(false);
            modelRunSideFront.SetActive(false);
            modelRunSideBack.SetActive(false);
            modelRunBack.SetActive(true);
            this.CreateDust();
        }        
        else if (direcZ > 0 && direcX !=0)
        {
            modelRunSide.SetActive(false);
            modelRunFront.SetActive(false);
            modelIdle.SetActive(false);
            modelIdleBack.SetActive(false);
            modelRunSideFront.SetActive(false);            
            modelRunBack.SetActive(false);
            modelRunSideBack.SetActive(true);
            this.CreateDust();
        }
        else if (direcZ < 0 && direcX != 0)
        {
            modelRunSide.SetActive(false);
            modelRunFront.SetActive(false);
            modelIdle.SetActive(false);
            modelIdleBack.SetActive(false);            
            modelRunBack.SetActive(false);
            modelRunSideBack.SetActive(false);
            modelRunSideFront.SetActive(true);
            this.CreateDust();
        }
        else if(direcZ < 0 && direcX==0)
        {
            modelRunSide.SetActive(false);
            modelRunBack.SetActive(false);
            modelIdle.SetActive(false);
            modelIdleBack.SetActive(false);
            modelRunSideFront.SetActive(false);
            modelRunSideBack.SetActive(false);
            modelRunFront.SetActive(true);
            this.CreateDust();
        }
        else if (direcX != 0)
        {
            modelIdleBack.SetActive(false);
            modelRunFront.SetActive(false);
            modelRunBack.SetActive(false);
            modelIdle.SetActive(false);
            modelRunSideFront.SetActive(false);
            modelRunSideBack.SetActive(false);
            modelRunSide.SetActive(true);
            this.CreateDust();
        }
        else if (direcX == 0 && direcZ == 0 && checkHistory == false)
        {
            modelRunSide.SetActive(false);
            modelIdleBack.SetActive(false);
            modelRunFront.SetActive(false);
            modelRunBack.SetActive(false);
            modelRunSideFront.SetActive(false);
            modelRunSideBack.SetActive(false);
            modelIdle.SetActive(true);
        }
        else if (direcX == 0 && direcZ == 0 && checkHistory == true)
        {
            modelRunFront.SetActive(false);
            modelRunBack.SetActive(false);
            modelIdle.SetActive(false);
            modelRunSide.SetActive(false);
            modelRunSideFront.SetActive(false);
            modelRunSideBack.SetActive(false);
            modelIdleBack.SetActive(true);
        }
    }
    protected virtual void HistoryKeyDown()
    {
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            checkHistory = false;
        }else if (Input.GetKeyDown(KeyCode.W))
        {
            checkHistory = true;
        }
    }

    protected virtual void CreateDust()
    {
        dust.Play();
    }
}
