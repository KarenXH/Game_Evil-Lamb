using System.Collections;
using UnityEngine;

public class ChangeColorWarning : MonoBehaviour
{
    [SerializeField] protected Color myColor;
    [SerializeField] protected float rFloat;
    [SerializeField] protected float gFloat;
    [SerializeField] protected float bFloat;
    [SerializeField] protected float aFloat;

    [SerializeField] protected SpriteRenderer sR;

    void Start()
    {
        rFloat = 1;
        gFloat = 0;
        bFloat = 0;
        aFloat = 1;
        sR = gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(FlickerWarning());
    }
    IEnumerator FlickerWarning()
    {
        aFloat = 0;
        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        sR.color = myColor;
        yield return new WaitForSeconds((float)0.3);
        aFloat = 1;
        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        sR.color = myColor;
        yield return new WaitForSeconds((float)0.3);
        StartCoroutine(FlickerWarning());
    }
}
