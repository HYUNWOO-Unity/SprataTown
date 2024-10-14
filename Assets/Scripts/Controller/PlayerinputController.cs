using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerinputController : SpartaController
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveinput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveinput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }
    public void OnFire(InputValue value)
    {
        IsAttacking = value.isPressed;
    }
}
