using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Card : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    private Camera mainCamera;
    private Vector3 offset;
    public Transform defaultParent;

    void Awake()
    {
        mainCamera = Camera.allCameras[0];
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        offset = transform.position - mainCamera.ScreenToWorldPoint(eventData.position);

        defaultParent = transform.parent;

        transform.SetParent(defaultParent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 newPosition;
        newPosition = mainCamera.ScreenToWorldPoint(eventData.position);
        newPosition.z = 0f; 
        transform.position = newPosition + offset;

    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(defaultParent);

        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    
    

}
