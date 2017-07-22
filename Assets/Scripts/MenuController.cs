using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {
    public float MenuX = 0;
    public float MenuY = 0;
    public GameObject menuCanvas;
    public GameObject Options;
    public GameObject MainMenu;
    public GameObject Gamemode;
	
	void Start () {
        RectTransform CanvasSize = menuCanvas.GetComponent<RectTransform>();
        RectTransform buttonOptionSize = Options.GetComponent<RectTransform>();
        RectTransform buttonMainSize = MainMenu.GetComponent<RectTransform>();
        RectTransform buttonModeSize = Gamemode.GetComponent<RectTransform>();

        //float height = Camera.main.orthographicSize * 2;
        //float width = height * Screen.width / Screen.height;
        float zScale = Camera.main.transform.position.z;

        float height = Mathf.Abs(2.0f * Mathf.Tan(0.5f * Camera.main.fieldOfView * Mathf.Deg2Rad) * zScale);
        float backgroundHeight = Mathf.Abs(2.0f * Mathf.Tan(0.5f * Camera.main.fieldOfView * Mathf.Deg2Rad) * (zScale - 1));
        float width = Mathf.Abs(height * Screen.width / Screen.height);
        float backgroundWidth = Mathf.Abs(backgroundHeight * Screen.width / Screen.height);

        transform.localScale = new Vector3(backgroundWidth, backgroundHeight, 1f);
        transform.position = new Vector3(backgroundWidth * MenuX, backgroundHeight * MenuY, 0f);

        menuCanvas.transform.position = new Vector3(transform.position.x, transform.position.y, -1f);

        CanvasSize.sizeDelta = new Vector2(width * 100, height * 100);

        Vector2 buttonSize = new Vector2(CanvasSize.sizeDelta.x / 3, CanvasSize.sizeDelta.y / 8);
        buttonOptionSize.sizeDelta = buttonMainSize.sizeDelta = buttonModeSize.sizeDelta = buttonSize;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
