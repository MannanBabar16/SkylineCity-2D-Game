using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    enum ItemType { Coin, Health, Ammo, InventoryItem};
    [SerializeField] ItemType itemType;

    NewPlayer newPlayer;

    [SerializeField]
    private string inventoryStringName;

    [SerializeField]
    private Sprite inventorySprite;

    // Start is called before the first frame update
    void Start()
    {
        newPlayer = GameObject.Find("Player").GetComponent<NewPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.name == "Player") {

            if (itemType == ItemType.Coin) {
                newPlayer.coinsCollected += 1;

            }
            else if (itemType == ItemType.Health) {
                if (newPlayer.health < 100) {
                    newPlayer.health += 1;
                  
                }

            }
            else if(itemType == ItemType.Ammo) {

            }else if (itemType == ItemType.InventoryItem) {
                newPlayer.AddInventoryItem(inventoryStringName, inventorySprite);
            }

            newPlayer.UpdateUi();
            Destroy(gameObject);
        }
    }
}
