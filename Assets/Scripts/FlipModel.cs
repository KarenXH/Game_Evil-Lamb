using UnityEngine;

public class FlipModel : MonoBehaviour
{
    public bool facingRight = true;
    public GameObject gameObjTargetToScale;
    void Update()
    {
        this.CheckToFlip();
    }

    protected virtual void CheckToFlip()
    {
        float h = Input.GetAxis("Horizontal");
        if (h > 0 && facingRight)
            Flip();
        else if (h < 0 && !facingRight)
            Flip();
    }
    protected virtual void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = gameObjTargetToScale.transform.localScale;
        theScale.x *= -1;
        gameObjTargetToScale.transform.localScale = theScale;
    }
}
