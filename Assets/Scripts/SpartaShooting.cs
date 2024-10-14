using UnityEngine;

public class SpartaShooting : MonoBehaviour
{
    private SpartaController controller;

    [SerializeField] private Transform projectileSpawnPosition;
    private Vector2 aimDirection = Vector2.right;

    public GameObject testPrefab;

    private void Awake()
    {
        controller = GetComponent<SpartaController>();
    }

    void Start()
    {
        controller.OnAttackEvent += OnShoot;
        
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        aimDirection = newAimDirection;
    }

    private void OnShoot()
    {
        CreateProjectile();
    }

    private void CreateProjectile()
    {
        
        Instantiate(testPrefab, projectileSpawnPosition.position, Quaternion.identity);
    }
}