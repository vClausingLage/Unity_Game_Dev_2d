using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
    }
}
