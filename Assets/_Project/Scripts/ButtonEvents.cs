using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonEvents : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    [SerializeField] UnityEvent eventOnEnter;
    [SerializeField] UnityEvent eventOnExit;
    [SerializeField] UnityEvent eventOnDown;
    [SerializeField] UnityEvent eventOnUp;
    [SerializeField] UnityEvent eventOnClick;

    void IPointerEnterHandler   .OnPointerEnter (PointerEventData eventData) => eventOnEnter?.Invoke();
    void IPointerExitHandler    .OnPointerExit  (PointerEventData eventData) => eventOnExit?.Invoke();
    void IPointerDownHandler    .OnPointerDown  (PointerEventData eventData) => eventOnDown?.Invoke();
    void IPointerUpHandler      .OnPointerUp    (PointerEventData eventData) => eventOnUp?.Invoke();
    void IPointerClickHandler   .OnPointerClick (PointerEventData eventData) => eventOnClick?.Invoke();
}
