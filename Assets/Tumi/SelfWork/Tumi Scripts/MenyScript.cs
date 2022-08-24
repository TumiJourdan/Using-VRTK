using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenyScript : MonoBehaviour
{

    public Zinnia.Action.BooleanAction MenuButton;
    public Zinnia.Action.FloatAction navButton;
    public Zinnia.Action.BooleanAction select;

    public GameObject menuCanvas;
    public List<Button> buttons;
    public int counter;

    private float timeDelta = 0.3f;
    private float timeElapsed;


    private float timeDelta1 = 0.5f;
    private float timeElapsed1;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        showMenu();
        NavigateMenu();

        
    }
    public void selectMenu()
    {
        if (menuCanvas.active == true)
        {
            timeElapsed1 -= Time.deltaTime;
            if (select.Value == true && timeElapsed1 < 0f)
            {
                buttons[counter].onClick.Invoke();
                timeElapsed1 = timeDelta1;
                
            }
        }
    }
    public void ext()
    {
        Debug.Log("EXIT");
        Application.Quit();
    }

    public void showMenu()
    {
        if (MenuButton.Value == true)
        {
            menuCanvas.SetActive(true);
        }
        else
        {
            menuCanvas.SetActive(false);
        }
    }
    public void NavigateMenu()
    {

        if (menuCanvas.active == true)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                if(i == counter)
                {
                    buttons[i].image.color= Color.blue;
                }
                else
                {
                    buttons[i].image.color = Color.white;
                }
            }
            buttons[counter].Select();
            timeElapsed -= Time.deltaTime;
            if (timeElapsed < 0 && navButton.Value != 0)
            {
                timeElapsed = timeDelta;
                if (navButton.Value < -0.1f)
                {
                    if (counter < buttons.Count-1)
                    {
                        counter += 1;
                    }
                }
                else if (navButton.Value > 0.1f)
                {
                    if (counter > 0)
                    {
                        counter -= 1;
                    }
                }
            }
        }
        
    }


}
