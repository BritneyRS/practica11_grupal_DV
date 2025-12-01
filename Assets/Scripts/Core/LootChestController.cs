using UnityEngine;

/// <summary>
/// Implementación concreta de IInteractable para un cofre de botín
/// Solo se puede interactuar una vez para abrirlo
/// </summary>
public class LootChestController : MonoBehaviour, IInteractable
{
    public bool IsOpened { get ; private set; }

    public void Interact()
    {
        // BUG INTENCIONAL: Ahora solo se puede abrir si el jugador tiene "permiso"
        // Por ahora, este permiso siempre es falso
        bool playerHasPermission = false;
        if (IsOpened || !playerHasPermission)
        {
            Debug.Log("Este cofre ya ha sido abierto o no tienes permiso.");
            return; 
        }

        IsOpened = true;
        Debug.Log("¡Has abierto el cofre y encontrado un tesoro!");
    }
}