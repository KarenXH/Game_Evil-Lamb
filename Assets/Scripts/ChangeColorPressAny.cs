using UnityEngine;
using UnityEngine.UI;

public class ChangeColorPressAny : MonoBehaviour
{
    public Color myColor;
    public float rFloat;
    public float gFloat;
    public float bFloat;
    public float aFloat;
    public bool flag;
    private int flag2 = 0;
    public float speedText;

    public float timeCount;

    private Text myText;

    public GameObject target;

    void Start()
    {
        myText = GetComponent<Text>();
        myText.enabled = false;
        rFloat = 1;
        gFloat = 0;
        bFloat = 0;
        aFloat = 1;
        flag = false;
    }

    void Update()
    {
        this.ChangeColor();
        this.WaitSecAndTurnOnMainMenu();
               
    }
    protected virtual void ChangeColor()
    {
        if (flag == true)
        {
            aFloat -= speedText;
            if (aFloat < 0)
            {
                flag = false;
                return;
            }
        }
        else if (flag == false)
        {
            aFloat += speedText;
            if (aFloat > 1)
            {
                flag = true;
                return;
            }
        }
        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        GetComponent<Text>().color = myColor;
    }

    protected virtual void WaitSecAndTurnOnMainMenu()
    {
        timeCount -= Time.deltaTime;
        if (timeCount <= 0 && flag2 == 0)
        {
            myText.enabled = true;
            flag2 = 1;
        }
        if (flag2 == 1 && Input.anyKey)
        {

            myText.enabled = false;
            flag2 = 2;
            Invoke("TurnOnObjMenu", 2.5f);

        }
    }
    protected virtual void TurnOnObjMenu()
    {
        target.SetActive(true);
    }
}
