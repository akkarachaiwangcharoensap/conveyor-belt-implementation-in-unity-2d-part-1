using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    /**
     * <summary>
     * Speed
     * </summary>
     */
    private float _speed = 1;

    public float speed
    {
        set
        {
            this._speed = value;
        }

        get
        {
            return this._speed;
        }
    }

    /**
     * <summary>
     * The 2d collision bounds
     * </summary>
     */
    private Bounds _bounds;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void FixedUpdate()
    {

    }

    /**
     * <summary>
     * Move left
     * </summary>
     *
     * <returns>
     * void
     * </returns>
     */
    public void MoveLeft()
    {
        Vector3 nextPosition = new Vector3(
            this.transform.position.x - this.speed * Time.deltaTime,
            this.transform.position.y,
            this.transform.position.z
        );

        this.transform.position = nextPosition;
    }

    /**
     * <summary>
     * Move right
     * </summary>
     *
     * <returns>
     * void
     * </returns>
     */
    public void MoveRight()
    {
        Vector3 nextPosition = new Vector3(
            this.transform.position.x + this.speed * Time.deltaTime,
            this.transform.position.y,
            this.transform.position.z
        );

        this.transform.position = nextPosition;
    }

    /**
     * <summary>
     * Move down
     * </summary>
     *
     * <returns>
     * void
     * </returns>
     */
    public void MoveDown()
    {
        Vector3 nextPosition = new Vector3(
            this.transform.position.x,
            this.transform.position.y - this.speed * Time.deltaTime,
            this.transform.position.z
        );

        this.transform.position = nextPosition;
    }

    /**
     * <summary>
     * Move up
     * </summary>
     *
     * <returns>
     * void
     * </returns>
     */
    public void MoveUp()
    {
        Vector3 nextPosition = new Vector3(
            this.transform.position.x,
            this.transform.position.y + this.speed * Time.deltaTime,
            this.transform.position.z
        );

        this.transform.position = nextPosition;
    }
}
