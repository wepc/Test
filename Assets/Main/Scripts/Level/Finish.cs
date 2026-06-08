using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.GetComponent<PlayerCore>() != null)
        {
            EventBus.OnFinish?.Invoke();
        }
    }
}
