using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Handler _handler;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        SetColor();
    }

    private void SetColor()
    {
        Color randomColor = new Color (Random.value, Random.value, Random.value);

        _renderer.material.color = randomColor;
    }
}
