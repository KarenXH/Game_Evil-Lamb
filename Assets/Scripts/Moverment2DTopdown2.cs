using UnityEngine;

public class Moverment2DTopdown2 : MonoBehaviour
{
    [SerializeField] public Vector3 moveInput;
    public float speed;
    Rigidbody rb;
    
    void Start()  {

        rb = GetComponentInParent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (StopPlayerForSec.Instance.IsStopping == true) { return; }
        this.GetInputMaganer();
        this.PlayerMovement();        
    }
    protected virtual void GetInputMaganer()
    {
        this.moveInput = InputManager2.Instance.M_Input;
    }
    protected virtual void PlayerMovement()
    {
        rb.MovePosition(transform.position + moveInput * speed * Time.deltaTime);        
    }
}
