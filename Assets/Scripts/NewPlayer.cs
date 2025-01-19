using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : PhysicsObject
{

    [SerializeField]
    private float maxSpeed = 1;

    [SerializeField]
    private float jumpSpeed = 10;

    public int coinsCollected;
    public TextMeshProUGUI coinsText;

    public float health;
    private float maxHealth = 100;
    public Image healthBar;

    private Vector2 healthBarOrgSie;

    public Dictionary<string, Sprite> inventory = new Dictionary<string, Sprite>();
    public Image inventoryItemImage;
    public Sprite keySprite;
    public Sprite inventoryItemBlank;

    // Start is called before the first frame update
    void Start()
    {
        healthBarOrgSie = healthBar.rectTransform.sizeDelta;
        UpdateUi();
    }

    // Update is called once per frame
    void Update() {
        targetVelocity = new Vector2(Input.GetAxis("Horizontal") * maxSpeed, 0);

        if (Input.GetButtonDown("Jump") && grounded) {
            velocity.y = jumpSpeed;
        } 

    }

    public void UpdateUi() {
        coinsText.text = coinsCollected.ToString();

        healthBar.rectTransform.sizeDelta=new Vector2(healthBarOrgSie.x*(health/maxHealth),healthBar.rectTransform.sizeDelta.y);
    }

    public void AddInventoryItem(string inventoryName, Sprite image) {
        inventory.Add(inventoryName, image);
        inventoryItemImage.sprite = inventory[inventoryName];
    }

    public void RemoveInventoryItem(string inventoryName) {
        inventory.Remove(inventoryName);
        inventoryItemImage.sprite = inventoryItemBlank;
    }
}
