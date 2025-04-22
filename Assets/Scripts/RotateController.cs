using Unity.IntegerTime;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    [SerializeField]
    Vector3 rotateSpeed = new Vector3(0, 45, 0);

    [SerializeField]
    Transform rotateTarget;

    private void Update()
    {
        rotateTarget.Rotate(rotateSpeed*Time.deltaTime);
    }
}
