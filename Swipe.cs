using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Swipe : MonoBehaviour
{
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;

    public void Swipes()
    {
        if(Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if(t.phase == TouchPhase.Began)
            {
                firstPressPos = new Vector2(t.position.x, t.position.y);
            }

            if(t.phase == TouchPhase.Ended)
            {
                secondPressPos = new Vector2(t.position.x, t.position.y);
                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
                currentSwipe.Normalize();
            }

            if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                CharacterControllerScript characterController = new CharacterControllerScript();
                characterController.Sprint();
            }
        }
    }
}
