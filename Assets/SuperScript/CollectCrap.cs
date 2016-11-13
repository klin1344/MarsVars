using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollectCrap : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "rock")
        {
            var r = col.gameObject.GetComponent<RockTypes>();
            var actualType = r.rocktype;
            var rockContainer = col.gameObject.GetComponent<holddata>().rockContainer;

            /*
        RockGreenPlant,
        RockCantPlant,
        RockNonEdible,
        RockGenericAF
             */
            switch (actualType)
            {
                case Rock.RockGreenPlant:
                    rockContainer.Add(actualType);
                    break;


                case Rock.RockCantPlant:
                    rockContainer.Add(actualType);
                    break;

                case Rock.RockNonEdible:
                    rockContainer.Add(actualType);
                    break;

                case Rock.RockGenericAF:
                    rockContainer.Add(actualType);
                    break;
            }
        }
    }
}
