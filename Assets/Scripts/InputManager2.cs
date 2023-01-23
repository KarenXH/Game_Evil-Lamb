using UnityEngine;

public class InputManager2 : MonoBehaviour
{
    private static InputManager2 instance;
    public static InputManager2 Instance { get => instance; }

    [SerializeField] protected Vector3 m_Input;
    public Vector3 M_Input { get => m_Input;}

    [SerializeField] private float isAttacking;
    public float IsAttacking { get => isAttacking; }
    private void Awake()
    {
        InputManager2.instance = this;
        isAttacking = 0;
    }
 
    void FixedUpdate()
    {
        if (StopPlayerForSec.Instance.IsStopping == true) { return; }
        this.GetInput();        
    }

    protected virtual void GetInput()
    {
        if(StopPlayerForSec.Instance.IsStopping == false)
        {
            m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            m_Input.Normalize();
            isAttacking = Input.GetAxis("Fire1");
        }
    }
}
