using UnityEngine;

public class TurnOnBossHealthBar : MonoBehaviour
{
    [SerializeField] protected GameObject maskOn;
    [SerializeField] protected GameObject bossHealthCanvas;

    void Update()
    {
        this.TurnOnHealthCanvas();
    }
    protected virtual void TurnOnHealthCanvas()
    {
        if (maskOn.activeSelf == true)
        {
            bossHealthCanvas.SetActive(true);
        }
        else if (maskOn.activeSelf == false)
        {
            bossHealthCanvas.SetActive(false);
        }
    }
}
