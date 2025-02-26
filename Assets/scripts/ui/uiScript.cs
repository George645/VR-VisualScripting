using TMPro;
using UnityEngine;

public class uiScript : MonoBehaviour{
    [SerializeField]bool isVisible = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
            
    }
    public void SetVisibility(bool toSet) {
        isVisible = toSet;
    }
    // Update is called once per frame
    void Update(){
        if (isVisible) {
            transform.GetChild(0).transform.position = new Vector3(500, transform.GetChild(0).transform.position.y, transform.GetChild(0).transform.position.z);
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else {
            transform.GetChild(0).transform.position = new Vector3(210, transform.GetChild(0).transform.position.y, transform.GetChild(0).transform.position.z);
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
