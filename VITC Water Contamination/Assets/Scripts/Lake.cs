using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lake : MonoBehaviour
{
    SpriteRenderer sprite;
    public float contamination = 0.0f;
    public float water = 10000.0f;
    public Vector4 Start_Color;
    // Start is called before the first frame update
    void Start()
    {
        Start_Color = new Vector4(0.0f, 1.0f, 0.0f, 1.0f);
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = Start_Color;
    }

    // Update is called once per frame
    void Update()
    {
        //sprite.color = new Color(contamination / water, 0.7172986f, 0.8490566f, 1);
    }
}
