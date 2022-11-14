using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSettings : MonoBehaviour
{

    [SerializeField]
    public string bestSongEver;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is called once");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is called every frame");
    }

    
}
