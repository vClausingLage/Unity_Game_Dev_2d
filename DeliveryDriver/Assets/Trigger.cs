using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        {
            Debug.Log("Object entered the trigger! " + other.gameObject.name);
        }
    }
}
