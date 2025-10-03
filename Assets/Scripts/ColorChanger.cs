using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Handler _handler;

    private void Start()
    {
        SetColor();
    }

    private void SetColor()
    {
        Color randomColor = new Color (Random.value, Random.value, Random.value);
        
        GetComponent<Renderer>().material.color = randomColor;
    }
}
