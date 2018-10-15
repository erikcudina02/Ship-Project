using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examination : MonoBehaviour {
    public float speedForward = 15;
    public Color Name;
    public SpriteRenderer Rend;
    // Use this for initialization

    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speedForward * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.D))
        {
            //Den får skeppet att rotera åt höger när du trycker på D
            transform.Rotate(0, 0, -360f * Time.deltaTime);
            Rend.color = new Color(0, 0, 1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 180f * Time.deltaTime);
            Rend.color = new Color(0, 1f, 0);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, (-speedForward + (speedForward / 2)) * Time.deltaTime, 0);

        }
        {

        }



	}
}
