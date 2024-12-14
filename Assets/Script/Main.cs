using UnityEngine;
using TMPro;
using System.Globalization;
using Unity.VisualScripting;
public class Main : MonoBehaviour
{
    private int num, gayka, control, click, price, Count2;
    public TextMeshProUGUI Count, Text_gayka, Text_gayka1, Text_gayka2, text_up, Count1;
    public GameObject main, shop, celendar, zaiavka, acepte;
    void Start()
    {
        click = 1;
        gayka = 0;
        price = 50;
        text_up.text = "Улучшить: " + price;
        Count2 = 20;
    }

    // Update is called once per frame
    public void ClickButton()
    {
        num  += click;
        control += click;
        if(control > 39)
        {
            control = 0;
            gayka++;
            Text_gayka.text = gayka.ToString();
        }
        Count.text = num.ToString();
    }
    public void ToShop()
    {
        main.SetActive(false);
        celendar.SetActive(false);
        shop.SetActive(true);
        Text_gayka1.text = gayka.ToString();
    }
    public void Aplication()
    {
        main.SetActive(false);
        shop.SetActive(false);
        celendar.SetActive(true);
        Text_gayka2.text = gayka.ToString();
    }
    public void Exit_app()
    {
        main.SetActive(true);
        shop.SetActive(false);
        celendar.SetActive(false);
        Text_gayka.text = gayka.ToString();
    }
    public void Exit()
    {
        main.SetActive(true);
        shop.SetActive(false);
        Text_gayka.text = gayka.ToString();
    }
    

    public void UpButton()
    {
        if(gayka > price)
        {
            click += 2;
            gayka -= price;
            Text_gayka1.text = gayka.ToString();
            price *= 2;
            text_up.text = "Улучшить: " + price;
        }
    }
    public void Zaiavka()
    {
        if(acepte)
        {

            if (control > 0 )
            {
            Count2 -= 1;
            Count1.text = Count2.ToString();
            }
            if (Count2 <= 0)
            {
            Count2 = 1;
            gayka += 50;
            Text_gayka2.text = gayka.ToString();
            }
        }
    }
}
