using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    [SerializeField]
    private string requiredInvventoryItemString;
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Player") {
            if (GameObject.Find("Player").GetComponent<NewPlayer>().inventory.ContainsKey(requiredInvventoryItemString)) {
                GameObject.Find("Player").GetComponent<NewPlayer>().RemoveInventoryItem(requiredInvventoryItemString);
                Destroy(gameObject);
            }
        }
    }
}
