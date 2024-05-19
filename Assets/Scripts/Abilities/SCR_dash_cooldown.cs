using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_dash_cooldown : MonoBehaviour
{
    public Slider slider;

    [SerializeField]
    GameObject player;

    [SerializeField]
    Outline outline;

    private P_StateManager script;
    private float dash_cooldown;

    bool display_outline = false;

    // Start is called before the first frame update
    void Start()
    {
        script = player.GetComponent<P_StateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        dash_cooldown = script.RemainingDashCooldown;
        slider.value = dash_cooldown;

        if (dash_cooldown == 0)
        {
            outline.enabled = true;
            outline.effectColor = Color.Lerp(outline.effectColor, Color.cyan, 0.12f);
        }
        else
        {
            outline.enabled = false;
            outline.effectColor = Color.black;
        }
    }
}
