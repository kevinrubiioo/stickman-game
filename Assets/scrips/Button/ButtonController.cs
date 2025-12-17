using UnityEngine;
using UnityEngine.EventSystems; 

public class ButtonDownHandler : MonoBehaviour, IPointerDownHandler
{
    Player player;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        player.Jump();
    }

}