using UnityEngine.EventSystems;
using UnityEngine;

public class Dungeon : MonoBehaviour, IDropHandler
{
    public Obstacle[] obstacles = new Obstacle[16];

    private void Awake()
    {
        //for (int i = 0; i < obstacles.Length; i++)
        //{
        //    obstacles[i] = emptyObstacle;
        //}
    }

    public void OnDrop(PointerEventData eventData)
    {
        Card card = eventData.pointerDrag.GetComponent<Card>();

        if (card) 
        {
            card.defaultParent = transform;

            
            
            //ActivateCard();
            
        }
            


    }
}
