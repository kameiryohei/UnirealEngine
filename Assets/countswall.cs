using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class countswall : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI AtacckMesseage;
    private int f_Atacck;
    void Start()
    {
        f_Atacck = 0;
    }
    void Update()
    {
        AtacckMesseage.text = string.Format("WallBreakCounter:{0}", f_Atacck);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "wall1" || other.gameObject.name == "wall2"
            || other.gameObject.name == "wall3" || other.gameObject.name == "wall4"
            || other.gameObject.name == "����1" || other.gameObject.name == "����2"
            || other.gameObject.name == "����3" || other.gameObject.name == "����4"
            || other.gameObject.name == "����5" || other.gameObject.name == "����6")
        {
            f_Atacck++;
        }
        
    }
}