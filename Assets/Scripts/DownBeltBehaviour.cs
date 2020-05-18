using UnityEngine;
using System.Collections;

public class DownBeltBehaviour : BeltBehaviour
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
                Vector2 itemPoint = new Vector2(itemBounds.min.x, itemBounds.max.y);

                // Do not move the item if the item point is not on the belt
                if (!bounds.Contains(itemPoint))
                {
                    continue;
                }

                ItemBehaviour itemBehaviour = item.GetComponent<ItemBehaviour>();
                itemBehaviour.speed = 5f;
                itemBehaviour.MoveDown();
            }
        }
    }
}
