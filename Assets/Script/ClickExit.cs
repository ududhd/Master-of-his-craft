using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickExit : MonoBehaviour
{
    private Color originalColor;
    public Color highlightColor = Color.yellow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalColor = GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
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
