using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSettings : MonoBehaviour
{

    [SerializeField]
    public string bestSongEver;
    private int counter = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is called once");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < counter; i++)
        {
            counter = 0;
            Debug.Log("This is called every frame");

            if (counter == 0)
                Debug.Log("It isnt doing so now because i made it not do so");
        }
        
    }

    
}
