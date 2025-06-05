using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private int n = 5.0f;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        float randomPosX = Random.Range(-10, 10); 
        float randomPosY = Random.Range(-10, 10); 
        float randomPosZ = Random.Range(-10, 10);
        transform.position = new Vector3(randomPosX, randomPosY, randomPosZ);

        transform.Rotate(20.0f * Time.deltaTime, 10.0f * Time.deltaTime, 0.0f);
    }
}
