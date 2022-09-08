using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockColorChange : MonoBehaviour
{
    public Block Block;
    private Material material;
   
    void Start()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
    }

    private void Update()
    {
        ChangeColor();
    }

    void ChangeColor() 
    {
        material.SetFloat("_Number",Block.RndNum);
    }
   
    
}
