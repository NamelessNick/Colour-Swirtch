using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    // Start is called before the first frame update

   public void OnButtonPress()
    {
         string scene = "Level_1";
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAA");
        SceneManager.LoadScene(scene);
    }    
    // Update is called once per frame

}
