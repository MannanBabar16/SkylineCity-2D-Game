using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    
    enum ItemType { Coin, Health, Ammo};
    [SerializeField] ItemType itemType;

    NewPlayer newPlayer;

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
                // Coins Update
                newPlayer.coinsCollected += 1;
            }

            else if (itemType == ItemType.Health) {

                if (newPlayer.health < 100) {
                    newPlayer.health += 1;
                }
               
            }

            else if(itemType == ItemType.Ammo) {

            }

            else {

            }
           
           
            //Update Ui
            newPlayer.UpdateUI();


            //gameObject.SetActive(false);                
            Destroy(gameObject);
        }
    }
}


