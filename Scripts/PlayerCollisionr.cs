using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionr : MonoBehaviour {
    [SerializeField]
    private Inventory inventory;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<Item>() != null)
        {
            inventory.AddToInventory(collision.gameObject);
        }
    }
}
