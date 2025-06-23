using UnityEngine;

public class pipeScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deathZone = -29;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deathZone)
        {
            Destroy(gameObject);
        }
    }
}
