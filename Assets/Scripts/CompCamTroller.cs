using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompCamTroller : MonoBehaviour
{
    public Transform target;
    public float distance = 10.0f;
    public float height = 5.0f;
    public float sensitivity = 100.0f;

    private float currentX = 0.0f;
    private int sliderValue = 0;
    
    public Slider slider;

    private void Start()
    {
        if (slider != null)
        {
            slider.onValueChanged.AddListener(OnSliderValueChanged);
        }
    }

    private void OnDestroy()
    {
        if (slider != null)
        {
            slider.onValueChanged.RemoveListener(OnSliderValueChanged);
        }
    }

    void Update()
    {
        //spin based on mouse click and drag
        if (Input.GetMouseButton(2))
        {
            currentX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        }
    }

    void LateUpdate()
    {
        //this fixes a weird error where only the clay sphere spins
        Quaternion rotation = Quaternion.Euler(0, currentX + sliderValue, 0);
        Vector3 direction = rotation * new Vector3(0, height, -distance);
        
        transform.position = target.position + direction;
        
        transform.LookAt(target.position + Vector3.up * height);
    }

    private void OnSliderValueChanged(float value)
    {
        sliderValue = (int)value;
    }
}
