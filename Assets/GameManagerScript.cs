using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //Import this

public class GameManagerScript : MonoBehaviour
{
    GameObject puzzle_object;
    PuzzleObjectScript puzzle_script;
    Text victory_text;
    // Start is called before the first frame update
    void Start()
    {
        puzzle_object = GameObject.Find("PuzzleObject");
        puzzle_script = puzzle_object.GetComponent<PuzzleObjectScript>();

        victory_text = GameObject.Find("Canvas/Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float _rotation_x = puzzle_script.rotation_x;
        float _rotation_y = puzzle_script.rotation_y;

        if(CompareAngle(_rotation_x, 0) && CompareAngle(_rotation_y, 0)){
            //We win!
            Debug.Log("Victory");

            //Text
            victory_text.enabled = true;
        }
    }

    //Check if the two given angles are almost similar
    private bool CompareAngle(float x1, float x2){
        float xn1 = OppositeAngleDir(x1);
        if(Mathf.Abs(Mathf.DeltaAngle(x1, x2)) < 1 || Mathf.Abs(Mathf.DeltaAngle(xn1, x2)) < 1){
            return true;
        }
        return false;
    }

    //Get the opposite direction of an angle
    private float OppositeAngleDir(float x){ 
        return((x+180)%360);
    } 
}
