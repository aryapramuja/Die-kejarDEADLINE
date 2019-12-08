using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadlineScroll : MonoBehaviour
{
    public float dlSpeed;
    public Renderer dlRend;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     	dlRend.material.mainTextureOffset += new Vector2(0f, dlSpeed * Time.deltaTime);
    }
}
