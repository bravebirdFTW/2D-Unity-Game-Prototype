using UnityEngine;

public class TriggerDebug : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"[TriggerEnter] {other.gameObject.name}, tag={other.tag}");
    }
    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log($"[TriggerStay] {other.gameObject.name}, tag={other.tag}");
    }
}
