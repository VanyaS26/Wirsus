using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    [SerializeField]private Text m_TextMeshProDate;
    [SerializeField]private Text TextMeshProTime;
    [SerializeField] private float second;
    [SerializeField] private float minitues;
    [SerializeField] private float hours;
    [SerializeField] private float day;
    [SerializeField] private float month;
    [SerializeField] private float year;
    void Start()
    {
        second = PlayerPrefs.GetFloat("second", 0);
        minitues = PlayerPrefs.GetFloat("minitues", 00);
        hours = PlayerPrefs.GetFloat("hours", 00);
        day = PlayerPrefs.GetFloat("day", 21);
        month = PlayerPrefs.GetFloat("month", 10);
        year = PlayerPrefs.GetFloat("year", 2025);
        TextMeshProTime.text = hours + ":" + minitues;
        m_TextMeshProDate.text = day + "." + month + "." + year;
    }

    void FixedUpdate()
    {
        second += Time.deltaTime;
        if(second >= 60)
        {
            second = 0;
            minitues++;
            if (minitues >= 60)
            {
                minitues = 0;
                hours++;
                if (hours >= 24)
                {
                    hours = 0;
                    day++;
                    if (day >= 30)
                    {
                        day = 0;
                        month++;
                        if(month >= 12)
                        {
                            month = 0;
                            year++;
                        }
                    }
                }
            }
        }
        PlayerPrefs.SetFloat("second", second);
        PlayerPrefs.SetFloat("minitues", minitues);
        PlayerPrefs.SetFloat("hours", hours);
        PlayerPrefs.SetFloat("day", day);
        PlayerPrefs.SetFloat("month", month);
        PlayerPrefs.SetFloat("year", year);
        TextMeshProTime.text = hours + ":" + minitues;
        m_TextMeshProDate.text = day + "." + month + "." + year;
    }
}
