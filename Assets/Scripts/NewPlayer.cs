using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewPlayer : PhysicsObject
{

    [SerializeField] private float maxSpeed =3f;
    [SerializeField] private float jumpPower = 10f;

    public int coinsCollected;
    public int health = 100;
    public int ammo;

    public TextMeshProUGUI coinsText;
    public Image healthBar;

    // Start is called before the first frame update
    void Start()
    {
       // healthBar = GameObject.Find("Health Bar").GetComponent<Image>();
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

       

    }
}
