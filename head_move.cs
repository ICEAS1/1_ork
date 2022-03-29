using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class head_move : MonoBehaviour
{
    Transform Steve_ork;
    // Start is called before the first frame update
    void Start()
    {
        Steve_ork = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Steve_ork.Translate(0, 0.5f, 0);
        print("Waaagh! Zog-zog!");
    }
}
