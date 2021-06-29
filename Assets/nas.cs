using UnityEngine;
using UnityEngine.Events;
public class nas : MonoBehaviour
{
    public UnityEvent OnplayerEnter, OnPlayerExit;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<player>(out var _))
        {
            OnplayerEnter.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        print("exit");
        if (collision.TryGetComponent<player>(out var _))
        {
            print("player_exit");
            OnPlayerExit.Invoke();
        }
    }
}