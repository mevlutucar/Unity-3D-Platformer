using UnityEngine;

public class SawController : MonoBehaviour
{
    [SerializeField]
    Transform sawObject;

    [SerializeField]
    float rotationSpeed = 100f;

    [SerializeField]
    float movementSpeed = 2f;

    [SerializeField]
    float firstPosition = -1.3f;

    [SerializeField]
    float lastPosition = 1.3f;

    private void Update()
    {
        sawObject.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);

        float continiousMovement = Mathf.PingPong(Time.time * movementSpeed, lastPosition - firstPosition) + firstPosition;

        sawObject.transform.localPosition = new Vector3(sawObject.transform.localPosition.x, sawObject.transform.localPosition.y, continiousMovement);
    }
}
