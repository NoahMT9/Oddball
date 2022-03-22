using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Swing : MonoBehaviour
{

    public Animator animBat;

    // Start is called before the first frame update
    void Start()
    {
        animBat = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            animBat.Play("Bat_Swing");
        }
    }
}
