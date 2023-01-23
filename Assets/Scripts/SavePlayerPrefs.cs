using UnityEngine;
using TMPro;

public class SavePlayerPrefs : MonoBehaviour
{
    [SerializeField] public static string key = "key_count";
    
    [SerializeField] protected int key_Value;
    [SerializeField] protected TextMeshProUGUI saveText;

    private void Start()
    {
        
    }
    void Update()
    {
        this.GetKeyValue();
    }
    protected virtual void GetKeyValue()
    {
        this.key_Value = KeyManager.Instance.KeyShow; 
    }

    public virtual void SaveGame()
    {        
        PlayerPrefs.SetInt(key, key_Value);
        
        PlayerPrefs.Save();
        saveText.text = "Saved";        
        Debug.Log(PlayerPrefs.GetInt(key));
    }

}
