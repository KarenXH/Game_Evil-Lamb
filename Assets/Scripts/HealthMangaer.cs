using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthMangaer : MonoBehaviour
{
    [SerializeField] protected Image HealthBar;
    [SerializeField] protected TextMeshProUGUI HealthText;
    [SerializeField] protected float MaxHealth = 7;
    [SerializeField] public static float CurrentHealth;

    [SerializeField] protected Color myColor;
    [SerializeField] protected float rFloat;
    [SerializeField] protected float gFloat;
    [SerializeField] protected float bFloat;
    [SerializeField] protected float aFloat;

    float oldHealth;

    void Start()
    {
        CurrentHealth = MaxHealth;
        oldHealth = CurrentHealth;
        rFloat = 1;
        gFloat = 0;
        bFloat = 0;
        aFloat = 1;
    }

    
    void Update()
    {
        this.HealthSystem();
        this.ChangeCurrentHealth();
        
    }
    protected virtual  void ChangeCurrentHealth()
    {
        if (oldHealth > CurrentHealth)
        {
            oldHealth = CurrentHealth;
            StartCoroutine(FlickerHeal());
        }
        else if (oldHealth < CurrentHealth)
        {
            oldHealth = CurrentHealth;
            return;
        }
        
    }
    protected virtual void HealthSystem()
    {
        HealthText.text = CurrentHealth + "/" + MaxHealth;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
        if (CurrentHealth >= MaxHealth) CurrentHealth = MaxHealth;
        if (CurrentHealth <= 0) CurrentHealth = 0;
    }

    IEnumerator FlickerHeal()
    {
        aFloat = 0;
        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        HealthBar.color = myColor;
        yield return new WaitForSeconds((float)0.1);
        aFloat = 1;
        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        HealthBar.color = myColor;
        yield return new WaitForSeconds((float)0.1);
        aFloat = 0;
        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        HealthBar.color = myColor;
        yield return new WaitForSeconds((float)0.1);
        aFloat = 1;
        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        HealthBar.color = myColor;
        yield return new WaitForSeconds((float)0.1);
        aFloat = 0;
        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        HealthBar.color = myColor;
        yield return new WaitForSeconds((float)0.1);
        aFloat = 1;
        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        HealthBar.color = myColor;      
    }
}
