using UnityEngine;
using System.Collections;

public class TopLeftBeltBehaviour : BeltBehaviour
{
    // Use this for initialization
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    /**
     * <summary>
     * Watch for the item on top of the belt
     * Move the items to the origin point then move it downward
     * </summary>
     */
    protected override void WatchForItem()
    {
        Bounds bounds = this.transform.GetComponent<Collider2D>().bounds;
        Vector2 size = bounds.size;

        Collider2D[] colliders = Physics2D.OverlapBoxAll(this.transform.position, size, 0);
        foreach (Collider2D collider in colliders)
        {
            if (collider.tag == Tags.Item)
            {
                Transform item = collider.GetComponent<Transform>();
                Bounds itemBounds = item.GetComponent<Collider2D>().bounds;
                Vector2 itemPoint = new Vector2(itemBounds.min.x, itemBounds.min.y);

                // Always move when the item is exactly or more on top of the collider
                if (!bounds.Contains(itemPoint))
                {
                    continue;
                }

                // Has the item reached the origin point?
                if (this.transform.position.y - item.position.y > 0)
                {
                    ItemBehaviour itemBehaviour = item.GetComponent<ItemBehaviour>();
                    itemBehaviour.speed = 5f;
                    itemBehaviour.MoveUp();
                }
                // If the item has reached the origin point, move it to right
                else
                {
                    ItemBehaviour itemBehaviour = item.GetComponent<ItemBehaviour>();
                    itemBehaviour.speed = 5f;
                    itemBehaviour.MoveRight();
                }
            }
        }
    }
}
