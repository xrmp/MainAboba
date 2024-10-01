using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Invaders : MonoBehaviour
{
    public Invader[] prefabs;

    public int rows = 5;
    public int columns = 11;
    public float speed = 10.0f;

    private Vector3 _direction = Vector2.right;

    public void Awake()
    {
        for (int row = 0; row < rows; row++)
        {
            float widht = 2.0f * (this.columns - 1);
            float height = 2.0f * (this.rows - 1);
            Vector2 centering = new Vector2(-widht / 2, -height / 2);
            Vector3 rowPosition = new Vector3(centering.x, centering.y + (row * 2.0f), 0.0f );

            for (int col = 0; col < this.columns; col++)


            {
                Invader invader = Instantiate(this.prefabs[row], this.transform);
                Vector3 position = rowPosition;
                position.x += col * 2.0f;
                invader.transform.localPosition = position;
            }
        }
    }

    private void Update()
    {
        this.transform.position += _direction * this.speed * Time.deltaTime;

        foreach (Transform invader in this.transform)
        {

        }
    }

}