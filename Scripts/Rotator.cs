using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10f;
    public int speed_v;
    public string diration;
    public int left_most_point;
    public int right_most_point;
    public int down_most_point;
    public int up_most_point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (diration == "up")
        {
            rb.velocity = Vector2.up * speed_v;
        }
        if (diration == "down")
        {
            rb.velocity = Vector2.down * speed_v;
        }
        if (diration == "right")
        {
            rb.velocity = Vector2.right * speed_v;
            check_left_right();
            Debug.Log("EEEEEEEEEEEEEEEEEEEEEEEEE");
        }
        if (diration == "left")
        {
            rb.velocity = Vector2.left * speed_v;
            check_left_right();
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAA");
        }
        else
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
            //Debug.Log("OIOIOIOOIO");
        }


    }
    void check_left_right()
    {
        if (left_most_point > gameObject.transform.position.x)
        {
            diration = "right";
            Debug.Log("OOOOOOOOOOOOOOOOOOO");
        }
        else if (right_most_point > gameObject.transform.position.x)
        {
            diration = "left";
            Debug.Log("IIIIIIIIIIIIIIIIIIIIIIIIIII");
        }
    }
    void check_up_down()
    {

    }
}
