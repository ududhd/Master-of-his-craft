using UnityEngine;
using TMPro;

public class Main : MonoBehaviour
{
    public bool FirstCompletQuest;
    private int num, gayka, control, click, price, CountQuest, Count2;
    public TextMeshProUGUI Count, Text_gayka, Text_gayka1, Text_gayka2, text_up, Count1, requiredClicksText;
    public GameObject main, shop, celendar, zaiavka, acepte, successMessage;

    void Start()
    {
        click = 1;
        gayka = 0;
        price = 50;
        text_up.text = "Улучшить: " + price;
        Count2 = 21;
        requiredClicksText.text = "клики: " + Count2;
        successMessage.SetActive(false); // Изначально уведомление скрыто
        Text_gayka2.text = gayka.ToString();
        FirstCompletQuest = false;
    }

    public void ClickButton()
    {
        num += click;
        control += click;
        if (control > 39)
        {
            control = 0;
            gayka++;
            Text_gayka.text = gayka.ToString();
        }
        Count.text = num.ToString();

        Zaiavka(); // Проверка выполнения задания при кликах
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
        if (gayka > price)
        {
            click += 2;
            gayka -= price;
            Text_gayka1.text = gayka.ToString();
            price *= 2;
            text_up.text = "Улучшить: " + price;
        }
    }

    public void AcceptQuest()
    {
        zaiavka.SetActive(false); // Закрываем окно заявок
        StartQuest(); // Начинаем выполнение задания
    }


    
    void CompleteQuest()
    {
        
        if (!FirstCompletQuest)
        {
            
            FirstCompletQuest = true;
            gayka += 50; // Награда за выполнение задания
            Text_gayka2.text = gayka.ToString();
            successMessage.SetActive(true); // Показываем уведомление об успешном выполнении
            Debug.Log("Задание выполнено!");

            successMessage.SetActive(false);
            CountQuest++;
            Count2 = 41;
            Count1.text = Count2.ToString();
        }
        else if (CountQuest == 1) 
        {
            Debug.Log("2");
            successMessage.SetActive(true); // Показываем уведомление об успешном выполнении
            Debug.Log("Задание выполнено!");
            gayka *= 2;
            successMessage.SetActive(false);
        }

            

    }
    void StartQuest()
    {
        if (CountQuest == 1)
        {
            
            Count2 = 41;
            requiredClicksText.text = "клики:" + Count2;
            Count1.text = Count2.ToString();
            

        }
        
        else
        {
            
            Count2 = 21; // Инициализация счетчика кликов для задания
            requiredClicksText.text = "клики:" + Count2;
            Count1.text = Count2.ToString(); // Обновление UI

        }
    }

    public void Zaiavka()
    {
        if (Count2 > 0)
        {
            Count2--;
            Count1.text = Count2.ToString();
            requiredClicksText.text = "клики: " + Count2;

            if (Count2 == 0)
            {
                CompleteQuest();
            }
        }
    }
}
