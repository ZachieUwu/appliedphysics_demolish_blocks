using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("Collided with a wall!");
            Destroy(gameObject, 3f);
        }
    }
}
