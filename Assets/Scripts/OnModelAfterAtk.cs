using UnityEngine;

public class OnModelAfterAtk : MonoBehaviour
{
    [SerializeField] protected GameObject modelAttack;
    [SerializeField] protected GameObject playerMovement;
    [SerializeField] protected GameObject flipModel;
    [SerializeField] protected GameObject modelMovement;
    void Update()
    {
        if (modelAttack.activeSelf == false)
        {
            if (Time.timeScale == 0) return;
            modelAttack.SetActive(false);
            modelMovement.SetActive(true);
            playerMovement.SetActive(true);
            flipModel.SetActive(true);
            
        }
    }
}
