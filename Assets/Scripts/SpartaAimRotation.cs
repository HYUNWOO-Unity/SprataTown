﻿using System;
using UnityEngine;

public class SpartaAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private SpartaController controller;

    private void Awake()
    {
        controller = GetComponent<SpartaController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
       float rotZ = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs (rotZ) > 90f;

        armPivot.rotation = Quaternion.Euler(0, 0,rotZ );
    }
}