using UnityEngine;
using UnityEngine.UI;

public class StarWarsOpening : MonoBehaviour
{
    public float speed = 10f;
    public float delay = 2f;
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(0, -rectTransform.rect.height);
        Invoke("StartAnimation", delay);
    }

    void Update()
    {
        if (!(rectTransform.anchoredPosition.y >= 0))
        {
            rectTransform.anchoredPosition += Vector2.up * speed * Time.deltaTime;
            //Destroy(gameObject);
        }
    }

    void StartAnimation()
    {
        // Add any sound effects or music here
    }
}