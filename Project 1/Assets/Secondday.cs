using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secondday : MonoBehaviour
{
    string heroName = "Flash";
        float heroHeight = 177.7f;
        int heroAge = 18;
        string heroSuperPower = "Super Fast";

        string villianName = "Mario";
        float villianHeight = 170f;
        int villianAge = 15;
        string villianSuperPower = "Flying";

   
    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = heroAge - villianAge;
        print("In our city, there is a villian called " + villianName + " ,his height is " + villianHeight + " ,his age is " + villianAge + " and his super power is " + villianSuperPower);
        print("We also have a hero called " + heroName + " ,his height is " + heroHeight + " ,his age is " + heroAge + " and his super power is " + heroSuperPower);
        print("The age difference between them is " + ageDifference);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
