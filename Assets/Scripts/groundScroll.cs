using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundScroll : MonoBehaviour
{
    public float groundSpeed;
    public Renderer groundRend;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     	groundRend.material.mainTextureOffset += new Vector2(groundSpeed * Time.deltaTime, 0f);
    }
}
