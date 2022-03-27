using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonElementChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    private TMP_Text _text;
    private Color _startColor; 

    private void OnEnable()
    {
        _text = GetComponentInChildren<TMP_Text>();
        _startColor = _text.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _text.color = Color.cyan;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _text.color = _startColor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _text.color = _startColor;
    }
}
