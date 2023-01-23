using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }

    [SerializeField] protected Vector3 m_Input;
    public Vector3 M_Input { get => m_Input; }



    private void Awake()
    {
        InputManager.instance = this;
    }

    void FixedUpdate()
    {
        this.GetInput();
    }

    protected virtual void GetInput()    {

        m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        m_Input.Normalize();


    }
}
