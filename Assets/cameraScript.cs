using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Assign your cube's transform in the Inspector
    public Vector3 offset = new Vector3(0, 5, -10); // Adjust as needed
    public float smoothSpeed = 1f;

    void LateUpdate()
    {
        if (target == null) return;
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(target);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
