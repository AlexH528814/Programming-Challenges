using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top3 : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;

    public string bestVideoGameEver = "The Witcher 3";
    public string bestFilmEver = "Empire Strikes Back";

    private MusicSettings cubemusic;
    private MusicSettings spheremusic;

    // Start is called before the first frame update
    void Start()
    {
        cubemusic = cube.GetComponent<MusicSettings>();
        spheremusic = sphere.GetComponent<MusicSettings>();

        Debug.Log(bestVideoGameEver);
        Debug.Log(bestFilmEver);
        Debug.Log(cubemusic.bestSongEver);
        Debug.Log(spheremusic.bestSongEver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
