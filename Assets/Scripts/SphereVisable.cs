using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SphereVisable: MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Slider slider;
    private Renderer sphereRenderer;

    void Start()
    {
        sphereRenderer = GetComponent<Renderer>();
        
        EventTrigger trigger1 = button1.gameObject.AddComponent<EventTrigger>();
        
        //awful code dont look at it
        EventTrigger.Entry pointerEnter1 = new EventTrigger.Entry();
        pointerEnter1.eventID = EventTriggerType.PointerEnter;
        pointerEnter1.callback.AddListener((eventData) => { OnButtonHover(true); });
        trigger1.triggers.Add(pointerEnter1);
        
        EventTrigger.Entry pointerExit1 = new EventTrigger.Entry();
        pointerExit1.eventID = EventTriggerType.PointerExit;
        pointerExit1.callback.AddListener((eventData) => { OnButtonHover(false); });
        trigger1.triggers.Add(pointerExit1);

        EventTrigger trigger2 = button2.gameObject.AddComponent<EventTrigger>();

        EventTrigger.Entry pointerEnter2 = new EventTrigger.Entry();
        pointerEnter2.eventID = EventTriggerType.PointerEnter;
        pointerEnter2.callback.AddListener((eventData) => { OnButtonHover(true); });
        trigger2.triggers.Add(pointerEnter2);
        
        EventTrigger.Entry pointerExit2 = new EventTrigger.Entry();
        pointerExit2.eventID = EventTriggerType.PointerExit;
        pointerExit2.callback.AddListener((eventData) => { OnButtonHover(false); });
        trigger2.triggers.Add(pointerExit2);
        
        EventTrigger sliderTrigger = slider.gameObject.AddComponent<EventTrigger>();
        
        EventTrigger.Entry sliderPointerEnter = new EventTrigger.Entry();
        sliderPointerEnter.eventID = EventTriggerType.PointerEnter;
        sliderPointerEnter.callback.AddListener((eventData) => { OnSliderHover(true); });
        sliderTrigger.triggers.Add(sliderPointerEnter);
        
        EventTrigger.Entry sliderPointerExit = new EventTrigger.Entry();
        sliderPointerExit.eventID = EventTriggerType.PointerExit;
        sliderPointerExit.callback.AddListener((eventData) => { OnSliderHover(false); });
        sliderTrigger.triggers.Add(sliderPointerExit);
    }

    void OnButtonHover(bool isHovering)
    {
        sphereRenderer.enabled = !isHovering;
    }

    void OnSliderHover(bool isHovering)
    {
        sphereRenderer.enabled = !isHovering;
    }
}
