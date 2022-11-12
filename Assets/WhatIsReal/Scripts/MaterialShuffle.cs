using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialShuffle : MonoBehaviour
{
    // Start is called before the first frame update

    public Material mat;
    public Vector2 offset;
    public ReflectionProbe probe;

    void Start()
    {
        mat.SetTextureOffset("_BaseMap",new Vector2(0,0));
    }

    public void shufflemat()
    {
        Vector2 currentoffset = mat.GetTextureOffset("_BaseMap");
        mat.SetTextureOffset("_BaseMap", currentoffset+offset);
        probe.RenderProbe();
    }

  
}
