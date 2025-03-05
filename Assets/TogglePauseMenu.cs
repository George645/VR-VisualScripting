using System.Collections;
using UnityEngine;

public class TogglePauseMenu : MonoBehaviour
{
    bool helpMenuOpen = false;
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            helpMenuOpen = !helpMenuOpen;
        }
        this.transform.GetChild(0).gameObject.SetActive(helpMenuOpen);

    }
}
