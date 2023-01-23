using UnityEngine;

public class CloseAnimChangeFrom : MonoBehaviour
{
    [SerializeField] protected GameObject change1;
    [SerializeField] protected GameObject change2;
    [SerializeField] protected GameObject change3;
    [SerializeField] protected GameObject change4;
    [SerializeField] protected GameObject bossSpi;
    [SerializeField] protected GameObject bossSpiAtk;
    protected virtual void CloseAnimeChangeFromAndBoss()
    {
        bossSpi.SetActive(true);
        bossSpiAtk.SetActive(true);
        change2.SetActive(false);
        change3.SetActive(false);
        change4.SetActive(false);
        change1.SetActive(false);
    }
    
}
