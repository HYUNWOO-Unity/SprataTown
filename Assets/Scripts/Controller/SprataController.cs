using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpartaController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;
    protected bool IsAttacking { get; set; }

    private float timeSinceLastAttack = float.MaxValue;
    private void Update()
    {
        HandleAttackDelay();
    }

    private void HandleAttackDelay()
    {
        if(timeSinceLastAttack  < 0.2f)
        {
            timeSinceLastAttack += Time.deltaTime;
        }
        else if (IsAttacking && timeSinceLastAttack >= 0.2f)
        {
            timeSinceLastAttack = 0f;
            CallAttackEvent();
        }
    }

    private void CallAttackEvent()
    {
        OnAttackEvent?.Invoke();
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); 
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
