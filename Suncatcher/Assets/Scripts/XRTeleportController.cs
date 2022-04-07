using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class XRTeleportController : MonoBehaviour
{
    public GameObject baseController;
    public GameObject teleportation;

    public InputActionReference teleportActionReference;

    [Space]

    // thumbstick activates teleporter
    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    private void Start() {
        teleportActionReference.action.performed += TeleportModeActivate;
        teleportActionReference.action.canceled += TeleportModeCancel;
    }


  private void TeleportModeActivate(InputAction.CallbackContext obj) => onTeleportActivate.Invoke();
  private void TeleportModeCancel(InputAction.CallbackContext obj) => Invoke("DeactivateTeleporter", 0.1f);

  void DeactivateTeleporter() => onTeleportActivate.Invoke();
}
