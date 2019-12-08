using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    public ObstacleSpawner obstacleSpawner;
    // Start is called before the first frame update
    void Start()
    {
        obstacleSpawner = FindObjectOfType<ObstacleSpawner>();
    }


    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.left * (speed + obstacleSpawner.speedUp) * Time.deltaTime);
        
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
