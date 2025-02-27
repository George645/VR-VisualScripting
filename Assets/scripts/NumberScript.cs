using Unity.VisualScripting;
using UnityEngine;

public class CharacterScript : MonoBehaviour{
    public GameObject rightThing;
    public GameObject leftThing;
    public bool isNumber = true;
    public string character;
    public void DestroyThoseOnTheRight() {
        if ((GameObject)Variables.Object(this).Get("rightThing") != null) {
            ((GameObject)Variables.Object(this).Get("rightThing")).GetComponent<CharacterScript>().DestroyThoseOnTheRight();
        }
        Destroy(this.gameObject);
    }
}
