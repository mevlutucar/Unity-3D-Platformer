using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform hedef;

    Vector3 mesafe = Vector3.zero;

    [SerializeField]
    private float takipHizi;

    private void Start()
    {
        mesafe = transform.position-hedef.position;
    }

    private void LateUpdate()
    {
        Vector3 mevcutPos = transform.position;

        Vector3 hedefPos = new Vector3(mevcutPos.x, hedef.position.y + mesafe.y, hedef.position.z + mesafe.z);

        Vector3 yeniPos = Vector3.Lerp(transform.position, hedefPos, takipHizi);

        transform.position = hedefPos;
    }
}
