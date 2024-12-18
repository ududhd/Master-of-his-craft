using UnityEngine;
using TMPro;

public class Main : MonoBehaviour
{
    public bool FirstCompletQuest;
    private int num, gayka, control, click, price, Count2, CountQuest;
    public TextMeshProUGUI Count, Text_gayka, Text_gayka1, Text_gayka2, text_up, Count1, requiredClicksText;
    public GameObject main, shop, celendar, zaiavka, acepte, successMessage;

    void Start()
    {
        click = 1;
        gayka = 0;
        price = 50;
        text_up.text = "Улучшить: " + price;
        Count2 = 20;
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
        gayka += 50; // Награда за выполнение первого задания
        Text_gayka2.text = gayka.ToString();
        successMessage.SetActive(true); // Показываем уведомление об успешном выполнении
        Debug.Log("Первое задание выполнено!");

        // Подготовка ко второму заданию
        CountQuest++;
        Count2 = 40; // Устанавливаем количество кликов для второго задания
        Count1.text = Count2.ToString();
        requiredClicksText.text = "клики: " + Count2;
        Debug.Log("Начинается второе задание!");
    }
    else if (CountQuest == 1)
    {
        gayka *= 2; // Награда за выполнение второго задания
        Text_gayka2.text = gayka.ToString();
        successMessage.SetActive(true); // Показываем уведомление об успешном выполнении
        Debug.Log("Второе задание выполнено!");
        CountQuest++;
    }
}


    void StartQuest()
    {
        if (CountQuest == 1) // Если начато второе задание
        {
            Count2 = 40; // Устанавливаем количество кликов для второго задания
            requiredClicksText.text = "клики: " + Count2;
            Count1.text = Count2.ToString();
            successMessage.SetActive(true); // Скрываем уведомление об успешном выполнении
            Debug.Log("Начато второе задание!");
        }
        else // Если начато первое задание
        {
            Count2 = 20; // Инициализация счетчика кликов для первого задания
            requiredClicksText.text = "клики: " + Count2;
            Count1.text = Count2.ToString();
            successMessage.SetActive(false); // Скрываем уведомление об успешном выполнении
            Debug.Log("Начато первое задание!");
        }
    }

    void Zaiavka()
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
