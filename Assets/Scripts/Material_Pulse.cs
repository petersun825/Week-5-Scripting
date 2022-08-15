using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material_Pulse : MonoBehaviour
{
    [Header("opacity parameters")]
    public float maxOpacity;
    public float minOpacity;
    public float opacityStep;

    [Header("Renderer and Material References")]
    public MeshRenderer objectRenderer;
    public Material objectMaterial;

    private Color tempColor;
    // Start is called before the first frame update
    void Start()
    {
        //get a reference to the mesh renderer attached to this object
        objectRenderer = gameObject.GetComponent < MeshRenderer>();
        objectMaterial = objectRenderer.material;

        tempColor = new Color(objectMaterial.color.r, objectMaterial.color.g, objectMaterial.color.b, objectMaterial.color.a);
        maxOpacity = 1.0f;
        minOpacity = 0.1f;
        opacityStep = 0.1f;
}

    // Update is called once per frame
    void Update()
    {
        //if opacity reached bounds then reseverse opacity step
        if (tempColor.a <= maxOpacity || tempColor.a >= maxOpacity)
            opacityStep *= -1.0f;

        //add opacity
        tempColor.a += opacityStep;
        objectMaterial.SetColor("_Color", tempColor);

     
    }
}
