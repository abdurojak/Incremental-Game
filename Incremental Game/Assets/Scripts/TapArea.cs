using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour
{
    public void OnPointerDown(PointerEventData eventData)

    {

        GameManager.Instance.CollectByTap(eventData.position, transform);

    }

}
