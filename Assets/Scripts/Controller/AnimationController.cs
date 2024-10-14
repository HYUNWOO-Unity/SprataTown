using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected SpartaController controller;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<SpartaController>();
    }
}
