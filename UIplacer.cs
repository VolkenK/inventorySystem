using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIplacer : MonoBehaviour {
    private Inventory inventory;
    [SerializeField]
    private GameObject button;
    [SerializeField]
    private GameObject context;



    // Use this for initialization
    void Start () {
        inventory = FindObjectOfType<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Q))
        {
            ButtonFill();
        }
	}

    public void ButtonFill()
    {
        for (int i = 0; i < inventory.GetObject().Count; i++)
        {
            Instantiate(button, new Vector3(0, i * 10, 0), new Quaternion(), context.transform).transform.localPosition = new Vector3(91.5f, i * -20 -150, 0);
        }
    }
}
