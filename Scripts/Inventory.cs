using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    private List<GameObject> inventory;

    private void Start()
    {
        inventory = new List<GameObject>();
    }

    public void AddToInventory(GameObject newItem)
    {
        //Debug.Log(newItem.name);
        inventory.Add(newItem);
        newItem.SetActive(false);
        Debug.Log("first collected item is " + inventory[0]);
        Debug.Log("second collected item is " + inventory[1]);
        Debug.Log("third collected item is" + inventory[2]);
    }
}

