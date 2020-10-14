using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lake : MonoBehaviour
{
    SpriteRenderer sprite;
    public float contamination = 0.0f;
    public float flow = 0.1f;
    public float timescale = 1.0f;
    public float water = 10000.0f;
    public float contamination_ratio = 0.0f;
    private Vector4 start_color;
    private Vector4 end_color;
    // Start is called before the first frame update
    void Start()
    {
        start_color = new Vector4(0.113f, 0.66f, 0.738f, 1.0f);
        end_color = new Vector4(0.589f, 0.582f, 0.369f, 1.0f);
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = start_color;
    }

    // Update is called once per frame
    void Update()
    {
        contamination_ratio = contamination / water;
        sprite.color = new Color(start_color[0] + ((end_color[0] - start_color[0]) * contamination_ratio), start_color[1] + ((end_color[1] - start_color[1]) * contamination_ratio), start_color[2] + ((end_color[2] - start_color[2]) * contamination_ratio), 1.0f);
        //sprite.color = new Color(contamination / water, 0.7172986f, 0.8490566f, 1);
        print(start_color[0] + ((end_color[0] - start_color[0]) * contamination_ratio));
    }
    void FixedUpdate()
    {
        if(contamination <= 0 )
        {
            contamination = 0;
        }
        else
        {
            contamination = contamination - (flow * timescale);
        }
    }
}
