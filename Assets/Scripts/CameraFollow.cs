using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform Tank;
    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, -10f);
    [SerializeField] private float smoothSpeed = 5f;

    void LateUpdate()
    {
        CameraFollowPlayer();
    }

    private void CameraFollowPlayer()
    {
        if (Tank == null) return;

        Vector3 desiredPosition = Tank.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }
}
