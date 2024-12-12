using UnityEngine;
using TMPro;
public class Main : MonoBehaviour
{
    private int num, gayka, control, click, price;
    public TextMeshProUGUI Count, Text_gayka, Text_gayka1, text_up;
    public GameObject main, shop;
    void Start()
    {
        click = 1;
        gayka = 1000;
        price = 50;
    }

    // Update is called once per frame
    public void ClickButton()
    {
        num  += click;
        control += click;
        if(control > 19)
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
        shop.SetActive(true);
        Text_gayka1.text = gayka.ToString();
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
}
