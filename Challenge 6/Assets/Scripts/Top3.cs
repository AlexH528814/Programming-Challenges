using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top3 : MonoBehaviour
{
    public string bestVideoGameEver = "The Witcher 3";
    public string bestFilmEver = "Empire Strikes Back";

    private MusicSettings musicSettings;

    // Start is called before the first frame update
    void Start()
    {
        musicSettings = GetComponent<MusicSettings>();

        Debug.Log(bestVideoGameEver);
        Debug.Log(bestFilmEver);
        Debug.Log(musicSettings.bestSongEver); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
