using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
            SceneManager.LoadScene("SampleScene");
        if (Input.GetKeyDown(KeyCode.Keypad1))
            SceneManager.LoadScene("Scene 1");
        if (Input.GetKeyDown(KeyCode.Keypad2))
            SceneManager.LoadScene("Scene 2");
        if (Input.GetKeyDown(KeyCode.Keypad3))
            SceneManager.LoadScene("Scene 3");

        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Sample Scene")
        {
            Debug.Log("You are in Sample Scene");
        }

        if (scene.name == "Scene 1")
        {
            Debug.Log("You are in Scene 1");
        }

        if (scene.name == "Scene 2")
        {
            Debug.Log("You are in Scene 2");
        }

        if (scene.name == "Scene 3")
        {
            Debug.Log("You are in Scene 3");
        }
    }



}
