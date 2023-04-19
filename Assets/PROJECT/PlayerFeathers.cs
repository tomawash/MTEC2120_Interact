using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class PlayerFeathers : MonoBehaviour
{
    [SerializeField] private UnityEvent myFeatherTrigger;

    public float feathers = 5f;
    public float stamina = 99f;

    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "FEATHERS: " + feathers.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Feather")
        {
            feathers++;
            myFeatherTrigger.Invoke();
            //on collision destroy the feather
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.GetComponent<Damage>())
        {
            feathers -= collision.gameObject.GetComponent<Damage>().damage;
        }
    }

    private void CrashCheck()
    {
        if (feathers < 0f)
        {
            Crash();
        }
    }

    private void Crash()
    {
        Debug.Log("You Crashed!");
    }
}
