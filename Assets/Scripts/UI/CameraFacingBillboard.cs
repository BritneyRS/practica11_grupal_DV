using UnityEngine;

/// <summary>
/// Fuerza a este objeto a mirar siempre hacia la camara principal
/// Esencial para UI en World Space (Diegética)
/// </summary>
public class CameraFacingBillboard : MonoBehaviour
{
    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void LateUpdate()
    {
        // LateUpdate asegura que la cámara ya se haya movido antes de rotar la UI
        // Hacemos que el objeto mire en la misma dirección que la cámara (paralelo),
        // lo que es visualmente más estable que LookAt()
        transform.forward = _mainCamera.transform.forward;
    }
}