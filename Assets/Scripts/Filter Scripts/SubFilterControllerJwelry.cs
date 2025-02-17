using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubFilterControllerJwelry : MonoBehaviour
{
    [SerializeField] private Toggle maleToggle;
    [SerializeField] private Toggle femaleToggle;
    [SerializeField] private Toggle kidsToggle;

    private void OnEnable()
    {
        maleToggle.isOn = false;
        femaleToggle.isOn = false;
        kidsToggle.isOn = false;
    }

    private void Start()
    {
        maleToggle.onValueChanged.AddListener(OnMaleClick);
        femaleToggle.onValueChanged.AddListener(OnFemaleClick);
        kidsToggle.onValueChanged.AddListener(OnKidsClick);
    }

    private void OnKidsClick(bool isOn)
    {
        FIlterManager.Instance.jweleryFiltre.SubFilter.kids = isOn;
    }

    private void OnFemaleClick(bool isOn)
    {
        FIlterManager.Instance.jweleryFiltre.SubFilter.female = isOn;
    }

    private void OnMaleClick(bool isOn)
    {
        FIlterManager.Instance.jweleryFiltre.SubFilter.male = isOn;
    }

    public void Disable()
    {
        this.transform.gameObject.SetActive(false);
    }

    public void Enable()
    {
        this.transform.gameObject.SetActive(true);
    }

    public void ResetFilter()
    {
        maleToggle.isOn = false;
        femaleToggle.isOn = false;
        kidsToggle.isOn = false;

        FIlterManager.Instance.jweleryFiltre.SubFilter.male = false;
        FIlterManager.Instance.jweleryFiltre.SubFilter.female = false;
        FIlterManager.Instance.jweleryFiltre.SubFilter.kids = false;
    }
}
