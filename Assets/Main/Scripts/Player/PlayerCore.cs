using UnityEngine;

public class PlayerCore : MonoBehaviour
{
    public int Hp { get; private set; }
    public float Speed {  get; private set; }

    [SerializeField]
    private Transform startPos;

    private void OnEnable()
    {
        ResetPlayer();
    }

    public void TakeDamage(int dmg)
    { 
        Hp -= dmg;
        if (Hp <= 0)
        {
            Die();
        }
        Debug.Log($"hp = {Hp}");
    }

    private void Die()
    {
        EventBus.OnPlayerDie?.Invoke(this);
    }

    public void ResetPlayer()
    {
        this.transform.position = startPos.position;
        Hp = 10;
        Speed = 10f;
    }
}
