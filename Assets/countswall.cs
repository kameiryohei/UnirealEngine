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
            || other.gameObject.name == "“à•Ç1" || other.gameObject.name == "“à•Ç2"
            || other.gameObject.name == "“à•Ç3" || other.gameObject.name == "“à•Ç4"
            || other.gameObject.name == "“à•Ç5" || other.gameObject.name == "“à•Ç6")
        {
            f_Atacck++;
        }
        
    }
}