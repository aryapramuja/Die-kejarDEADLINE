using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroll : MonoBehaviour
{
    public float bgSpeed;
    public Renderer bgRend;

    public ObstacleSpawner obstacleSpawner;

    // Start is called before the first frame update
    void Start()
    {
        obstacleSpawner = FindObjectOfType<ObstacleSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
     	bgRend.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime + obstacleSpawner.speedUp*0.00025f, 0f);
    }
}
