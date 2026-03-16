using UnityEngine;

public class Firing : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Mathf.Abs(Camera.main.transform.position.z - 0);
        Vector3 pos = Camera.main.ScreenToWorldPoint(mousePosition);
        
        Instantiate(bullet, pos, Quaternion.identity);
    }
}
