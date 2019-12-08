using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundScroll : MonoBehaviour
{
    public float groundSpeed;
    public Renderer groundRend;

    public ObstacleSpawner obstacleSpawner;


    // Start is called before the first frame update
    void Start()
    {
        obstacleSpawner = FindObjectOfType<ObstacleSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
     	groundRend.material.mainTextureOffset += new Vector2(groundSpeed * Time.deltaTime + obstacleSpawner.speedUp*0.00030f, 0f);
    }
}
