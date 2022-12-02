using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topdown8Movement2D : MonoBehaviour
{
    private Rigidbody rb;
    private Animation anim;
    public float movementSpeed;
    private Vector2 movementInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Animate();
    }

    private void Move()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Verticval = Input.GetAxisRaw("Vertical");

        if(Horizontal== 0 && Verticval == 0)
        {
            rb.velocity = new Vector2(0, 0);
            return;
        }

        movementInput = new Vector2(Horizontal, Verticval);
        rb.velocity = movementInput * movementSpeed * Time.deltaTime;
    }

    private void Animate()
    {
        //anim.SetFloat("MovementX");
    }
}
