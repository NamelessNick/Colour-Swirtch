using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColourChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CurrentGameObject;
    public Color ImageColor;
    private bool up = false;
    private Material currentMat;
    void Start()
    {
        // 31.875 iterations per second
        //ImageColor = Background.color;
        CurrentGameObject = gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentGameObject = gameObject;
        transform.Rotate(0, 0, 50 * Time.deltaTime);
        if (ImageColor.a == 0)
            up = true;
        if (ImageColor.a == 255)
            up = false;

        if (up)
        {
            ImageColor.a += 3;
            //Debug.Log("AAAAAAAAAA");
        }
        else
        {
            ImageColor.a -= 3;
            //Debug.Log("EEEEEEEEEE");
        }
        //Change_A(CurrentGameObject.GetComponent<Renderer>().material, ImageColor.a);
    }
    void Change_A(Material mat, float alphaVal)
    {
        Color OldColor = mat.color;
        Color NewColor = new Color(OldColor.r, OldColor.g, OldColor.b, alphaVal);
        currentMat.SetColor("_Color", NewColor);
    }
}
