using UnityEngine;
using TMPro;
public class Main : MonoBehaviour
{
    private int num = 0;
    public TextMeshProUGUI Count;
    public GameObject main, shop;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ClickButton()
    {
        num++;
        Count.text = num.ToString();
    }
    public void ToShop()
    {
        main.SetActive(false);
        shop.SetActive(true);
    }
    public void Exit()
    {
        main.SetActive(true);
        shop.SetActive(false);
    }
}
