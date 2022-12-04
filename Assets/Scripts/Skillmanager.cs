using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skillmanager : MonoBehaviour
{
    public static Skillmanager instance;
    public Detail[] skills;
    public Detail2[] skillButtons;

    [SerializeField] private Skill activateSkill;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
