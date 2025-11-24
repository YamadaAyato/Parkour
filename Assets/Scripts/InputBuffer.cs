using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
///         プレイヤー入力クラス
/// </summary>
public class InputBuffer : MonoBehaviour
{
    ParkourAction _palkourAction;

    private void Awake()
    {
        _palkourAction = new ParkourAction();
    }

    private void HandleMove(InputAction.CallbackContext ctx)
    {
        Vector2 moveInput = ctx.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
}
