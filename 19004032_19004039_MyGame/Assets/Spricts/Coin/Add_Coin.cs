using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Add_Coin : MonoBehaviour
{
    public static int numberOfCoins = 0;
    //public static int numberOfCoins_Shop;

    [SerializeField] TextMeshProUGUI conisText;
   // [SerializeField] TextMeshProUGUI conisText_Shop;
    
    private void Awake()
    {
      //  numberOfCoins_Shop = PlayerPrefs.GetInt("NumberOfCoins", 0);
    }

    // Update is called once per frame
    void Update()
    {
      conisText.text = numberOfCoins.ToString();
    }
}
