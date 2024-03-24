using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : PhysicsObject
{

    [SerializeField] private float maxSpeed =3f;
    [SerializeField] private float jumpPower = 10f;

    public int coinsCollected;
    public int health = 100;
    public int ammo;
    private int maxhealth = 100;


    public TextMeshProUGUI coinsText;
    

    public Image healthBar;

    private Vector2 healthBarOrigSize;

    // Start is called before the first frame update
    void Start()
    {
        // healthBar = GameObject.Find("Health Bar").GetComponent<Image>();

        healthBarOrigSize = healthBar.rectTransform.sizeDelta;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {

        // we are not using += (adding any value) thats why we are not multiplying by it Time.deltaTime

        targetVelocity = new Vector2(Input.GetAxis("Horizontal")*maxSpeed,0);

        if (Input.GetButtonDown("Jump") && grounded==true) {
            velocity.y = jumpPower;
        }
        
    }


    //Update Ui elements
    
    public void UpdateUI() {

        coinsText.text = coinsCollected.ToString();

        healthBar.rectTransform.sizeDelta = new Vector2(healthBarOrigSize.x * ((float)health / (float)maxhealth), healthBar.rectTransform.sizeDelta.y);

      
       

    }
}
