using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour {

    public Material MouseOverMaterial;

    Material OriginMaterial;
    Material Current;

    MeshRenderer m_Renderer;

    GameManager GM;

    // Use this for initialization
    void Start ()
    {
        GameObject Manager = GameObject.Find("GameManager");

        GM = Manager.GetComponent<GameManager>();

        OriginMaterial = GetComponent<Renderer>().material;
	}

    void OnMouseOver()
    {
        GetComponent<Renderer>().material = MouseOverMaterial;
        Debug.Log("Mouse is over me");
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material = OriginMaterial;
        Debug.Log("Mouse is NOT over me");
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "Clickable")
        {
            GM.isDead = true;
            GM.SuccessCount++;
            gameObject.SetActive(false);
            Debug.Log("AGGGGHHHH I'VE BEEN CLICKED!!!!");
        }

        else if (gameObject.tag == "StartButton")
        {
            GM.Panels[4].SetActive(false);
            GM.Players[0].SetActive(true);
        }

        else if(gameObject.tag == "QuitButton")
        {
            Application.Quit();
        }

        else if(gameObject.tag == "RestartButton")
        {
            GM.Start();
        }
    }

}
