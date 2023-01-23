using UnityEngine;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] protected GameObject mainMenu;
    [SerializeField] protected GameObject setting;
    [SerializeField] protected GameObject quitToMainMenu;
    [SerializeField] protected GameObject quit;

    [SerializeField] protected TextMeshProUGUI saveText;

    [SerializeField] protected GameObject target;

    // Update is called once per frame
    void Update()
    {
        this.CheckOnOffMenu();        
    }

    protected virtual void CheckOnOffMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(mainMenu.activeSelf==false && setting.activeSelf==false &&
                quitToMainMenu.activeSelf==false && quit.activeSelf == false)
            {
                TurnOnObjMenu();
            }
            else if(setting.activeSelf != true &&
                quitToMainMenu.activeSelf != true && quit.activeSelf != true)
            {
                TurnOffObjMenu();
            }
        }
    }
    public virtual void TurnOnObjMenu()
    {
        saveText.text = "Save";
        Time.timeScale = 0;
        target.SetActive(true);
    }
    public virtual void TurnOffObjMenu()
    {
        Time.timeScale = 1;
        target.SetActive(false);
    }
}
