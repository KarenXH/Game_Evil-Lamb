using UnityEngine;
using TMPro;

public class KeyManager : MonoBehaviour
{
    private static KeyManager instance;
    [SerializeField] protected TextMeshProUGUI keyText;
    [SerializeField] protected int keyShow=0;

    public static KeyManager Instance { get => instance; }
    public int KeyShow { get => keyShow;}

    private void Awake()
    {
        KeyManager.instance = this;
    }

    private void Update()
    {
        this.ShowKeySystem();
    }
    protected virtual void ShowKeySystem()
    {
        keyShow = PlayerPrefs.GetInt(SavePlayerPrefs.key);
        keyText.text = "x" + keyShow;
    }

  
    

    
}
