using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleObjectScript : MonoBehaviour
{
    public float rotation_speed = 0.04f;
    public float rotation_x = 0;
    public float rotation_y = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Randomize starting rotation
        transform.Rotate(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), 0.0f);

        //
        GetRotationValue();
    }

    // Update is called once per frame
    void Update()
    {
        GetRotationValue();
    }

	void OnMouseDrag()
	{
        float _rotation_x = Input.GetAxis("Mouse X")*rotation_speed;
        float _rotation_y = Input.GetAxis("Mouse Y")*rotation_speed;

        transform.RotateAround(Vector3.down, _rotation_x);
        transform.RotateAround(Vector3.right, _rotation_y);
	}

    void GetRotationValue()
    {
        rotation_x = gameObject.transform.eulerAngles.x;
        rotation_y = gameObject.transform.eulerAngles.y;
    }
}
