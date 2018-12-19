using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int SuccessCount;

    public bool isDead = false;

    public GameObject[] Players;

    public GameObject[] Panels;

    GameObject[] Cameras;


	// Use this for initialization
	public void Start ()
    {
        Players[0] = GameObject.Find("Player1");
        Players[1] = GameObject.Find("Player2");
        Players[2] = GameObject.Find("Player3");
        Players[3] = null;

        Players[0].SetActive(false);
        Players[1].SetActive(false);
        Players[2].SetActive(false);

        Panels[0] = GameObject.Find("Death1");
        Panels[1] = GameObject.Find("Death2");
        Panels[2] = GameObject.Find("Death3");
        Panels[3] = GameObject.Find("End");
        Panels[4] = GameObject.Find("Start");

        Panels[0].SetActive(false);
        Panels[1].SetActive(false);
        Panels[2].SetActive(false);
        Panels[3].SetActive(false);

        Cameras[0] = GameObject.Find("Camera1");
        Cameras[1] = GameObject.Find("Camera2");
        Cameras[2] = GameObject.Find("Camera3");
        Cameras[3] = GameObject.Find("Camera4");

        SuccessCount = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isDead == true)
        {
            Players[SuccessCount].SetActive(false);
            Panels[SuccessCount].SetActive(true);
            SuccessCount++;
            Players[SuccessCount].SetActive(true);
            Cameras[SuccessCount].SetActive(true);
            Cameras[SuccessCount - 1].SetActive(false);

            isDead = false;
                      
        }
	}
}
