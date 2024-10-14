using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 5.0f;
    public GameObject player;

    private void Update()
    {
        Vector3 dir = player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime, 0.0f);
        this.transform.Translate(moveVector);
    }
    


    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}
