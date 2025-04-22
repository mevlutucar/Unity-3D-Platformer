using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Engel, Player nesnesi ile çarpýþtý.");

            collision.gameObject.GetComponent<HealthController>().DamageOn(10);
        }

    }

}
