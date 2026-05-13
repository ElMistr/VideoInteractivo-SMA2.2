using UnityEngine;

public class CameraFollowSound3D : MonoBehaviour
{
    [Header("Objeto con AudioSource")]
    public Transform soundTarget;

    [Header("Configuración cámara")]
    public Vector3 offset = new Vector3(0f, 4f, -6f);

    [Header("Suavizado")]
    [Range(1f, 20f)]
    public float followSpeed = 5f;

    [Header("Rotación")]
    public bool lookAtTarget = true;

    void LateUpdate()
    {
        if (soundTarget == null)
            return;

        // Posición deseada
        Vector3 targetPosition = soundTarget.position + offset;

        // Movimiento suave
        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            followSpeed * Time.deltaTime
        );

        // Mirar al objetivo
        if (lookAtTarget)
        {
            transform.LookAt(soundTarget);
        }
    }
}