using UnityEngine;

public class Clickcalendar : MonoBehaviour
{
    private Color originalColor;
    public Color highlightColor = Color.yellow;

    void Start()
    {
        originalColor = GetComponent<SpriteRenderer>().color;
    }


    void OnMouseEnter()
    {
        // �������� ���� �� ��������� ��� ���������
        GetComponent<SpriteRenderer>().color = highlightColor;
    }
    void OnMouseExit()
    {
        // ���������� ���� � �������� ���������
        GetComponent<SpriteRenderer>().color = originalColor;
    }
}
