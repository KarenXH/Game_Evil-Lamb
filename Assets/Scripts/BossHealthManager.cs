using UnityEngine;
using UnityEngine.UI;

public class BossHealthManager : MonoBehaviour
{
    [SerializeField] protected Image bossHealthBar;
    [SerializeField] private float maxBossHealth =16;
    [SerializeField] public static float currentBossHealth;

    [SerializeField] protected GameObject uI;

    /*//private static BossHealthManager instance;
     * public static BossHealthManager Instance { get => instance; set => instance = value; }
    
    public float CurrentBossHealth { get => currentBossHealth; set => currentBossHealth = value; }
    public float MaxBossHealth { get => maxBossHealth;  }

    private void Awake()
    {
        BossHealthManager.instance = this;
    }*/
    private void Start()
    {
        currentBossHealth = maxBossHealth;
    }
    void Update()
    {
        this.BossHealthSystem();   
    }
    protected virtual void BossHealthSystem()    {
        
        bossHealthBar.fillAmount = currentBossHealth / maxBossHealth;
        if (currentBossHealth >= maxBossHealth) currentBossHealth = maxBossHealth;
        if (currentBossHealth < 0) currentBossHealth = 0;
    }
}
