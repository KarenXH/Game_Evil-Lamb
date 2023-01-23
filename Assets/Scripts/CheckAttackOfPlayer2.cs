using UnityEngine;

public class CheckAttackOfPlayer2 : MonoBehaviour
{
    private static CheckAttackOfPlayer2 instance;
    [SerializeField] protected GameObject parentGameOBJ;
    [SerializeField]  int hpEnemy =3;
    [SerializeField] protected AudioSource audioSource;

    public static CheckAttackOfPlayer2 Instance { get => instance; set => instance = value; }
    public int HpEnemy { get => hpEnemy; set => hpEnemy = value; }

    private void Awake()
    {
        CheckAttackOfPlayer2.instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("PlayerAttack"))
        {
            audioSource.Play();
            hpEnemy -= 1;
        }
    }
}
