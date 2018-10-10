using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionr : MonoBehaviour {
    [SerializeField]
    private Inventory inventory;


    private void Start()
    {
        inventory = GameObject.Find("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<Item>() != null)
        {
            inventory.AddToInventory(collision.gameObject);
        }
    }
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            foreach(GameObject obj in inventory.GetObject())
            {
                //Debug.Log("yes");
                Debug.Log(obj.GetComponent<Item>().GetName());
            }
        }
    }
}
