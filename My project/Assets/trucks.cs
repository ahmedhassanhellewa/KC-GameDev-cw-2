using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trucks : MonoBehaviour
{
    string heroname = " Leo ";
    float heroheight = 176.3f;
    int heroage = 26;
    string herosuperpower = " flying & vanishing ";

    string villainname = " Nickolous ";
    float villainheight = 173.1f;
    int villainage = 23;
    string villainsuperpower = " fast & shoots laser ";

    // Start is called before the first frame update
    void Start()
    {
        print(" hero name is " + heroname + " hero age is " + heroage + " hero height is " + heroheight + " hero superpower is " + herosuperpower);
        print(" villain name is " + villainname + " villain age is " + villainage + " villain height is " + villainheight + " villain superpower is " + villainsuperpower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
