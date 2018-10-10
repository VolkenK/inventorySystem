using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public enum posName { stickyStick, smellyStick, cheezyPickle, healthPotion, sword, bat, vleermuis, nuke, statueOfStick};
    private posName myName;

    void Start()
    {
        myName = (posName)Random.Range(0, 8);
        Debug.Log(myName);
    }

    public GameObject OnPickUp()
    {
        return gameObject;
    }
    public string GetName()
    {
        
        return myName.ToString();
    }
}
