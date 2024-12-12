using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    private Color originalColor;
    public Color highlightColor = Color.yellow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalColor = GetComponent<SpriteRenderer>().color;
    }


    void OnMouseEnter()
    {
        // Изменяем цвет на подсветку при наведении
        GetComponent<SpriteRenderer>().color = highlightColor;
    }
    void OnMouseExit()
    {
        // Возвращаем цвет в исходное состояние
        GetComponent<SpriteRenderer>().color = originalColor;
    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Игра");
    }
}
