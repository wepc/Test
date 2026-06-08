using UnityEngine;

public class TrapController : MonoBehaviour
{
    public int Damage { get; private set; }

    private void OnEnable()
    {
        Damage = 5;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<PlayerCore>() != null)
        {
            other.transform.GetComponent<PlayerCore>().TakeDamage(Damage);
        }
    }
}
