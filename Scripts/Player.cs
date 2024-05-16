using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jump = 5f;
    public string CurrentColour;
    public SpriteRenderer sr;
    public Color Blue;
    public Color Yellow;
    public Color Pink;
    public Color Purple;
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        SetRandomColour();
    }

    // Update is called once per frame
    void Update()
    {                                           // 0 = LC / 1 = RC / 2 = MMB
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jump;
        }
        else if (Input.GetMouseButtonDown(0))
        {

            rb.velocity = Vector2.up * jump/2;
        }
    }
    public void OnTriggerEnter2D(Collider2D collition)
    {
        string colour_collision = collition.name;
        if (("End_Point" == collition.name))
        {
            level += 1;
            Debug.Log(level);
            if (level > 4){
                level = 4;}
            
            string scene = "Level_" + level;
            SceneManager.LoadScene(scene);
            Debug.Log(scene);


        }
        else if ("ColourChanger" == collition.tag)
        {
            SetRandomColour();
            Destroy(collition.gameObject);
        }
        else if (CurrentColour != colour_collision)
        {
            SceneManager.LoadScene("Level_1");

        }
            
     
      
    }
    void SetRandomColour()
    {
        int number = Random.Range(0, 3);
        if (number == 0 & CurrentColour != "Blue")
        {
            CurrentColour = "Blue";
            sr.color = Blue;

        }
        else if (number == 1 & CurrentColour != "Yellow")
        {
            CurrentColour = "Yellow";
            sr.color = Yellow;
        }
        else if (number == 2 & CurrentColour != "Blue")
        {
            CurrentColour = "Pink";
            sr.color = Pink;
        }
        else if (number == 3 & CurrentColour != "Purple")
        {
            CurrentColour = "Purple";
            sr.color = Purple;
        }
        else
        {
            SetRandomColour();
        }
        //Debug.Log(CurrentColour);
    }
}
