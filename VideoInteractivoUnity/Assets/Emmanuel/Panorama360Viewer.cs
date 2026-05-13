using UnityEngine;

public class Panorama360Viewer : MonoBehaviour
{
    [Header("Velocidad de rotación")]
    public float mouseSensitivity = 100f;

    float rotationX = 0f;
    float rotationY = 0f;

    void Start()
    {
        // Bloquea el cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Movimiento del mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotationY += mouseX;
        rotationX -= mouseY;

        // Limita la vista vertical
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        // Rotación de cámara
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0f);
    }
}