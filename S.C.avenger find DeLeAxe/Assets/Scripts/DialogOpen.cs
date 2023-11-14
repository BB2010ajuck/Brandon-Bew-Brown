using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOpen : MonoBehaviour
{

    public string dialog;
    public GameObject interfaceManager;
    public PlayerHolding pHolding;
    public bool begin = true;
    public bool end = false;
    private string[] collectibles;
    private int clue;

    private AudioSource greeting;

    // Start is called before the first frame update
    void Start()
    {
        greeting = GetComponent<AudioSource>();
        collectibles = new string[] { "Tv", "pennywise's ballon", "Floatie", "target", "pipe", "Ip adress", "Nemo", "pepqueak House", "red horn", "magical hat" };
        createClue();
    }
    public void createClue()
    {
        clue = Random.Range(0, 9);
        searchDialog();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!begin && pHolding.Verify())
        {
            checkClue();
        }
        greeting.Play(0);
        interfaceManager.GetComponent<InterfaceManager>().ShowBox(dialog, clue);
    }

    private void checkClue()
    {
        if (pHolding.holdValue == clue)
        {
            dialog = "You found my " + collectibles[clue] + ", me give you social credit";
            end = true;
        }
        else
        {
            dialog = "No that's not my " + collectibles[clue] + " U peice of poop";
        }
    }

    public void coinsScattered()
    {
        begin = false;
    }

    public void searchDialog()
    {

        switch (clue)
        {
            case 0:
                dialog = "Hey there! An indian scamer took my Tv, You help me or I turn into de hulk >:(";
                break;
            case 1:
                dialog = "Hey there! Pennywise lost his ballon, he said if I don't find it i'll be gerogie :(";
                break;
            case 2:
                dialog = "Hey there! My daughter is drowning and I need you to find da floatie :O";
                break;
            case 3:
                dialog = "Hey there! I lost a target, I need you to help me find it";
                break;
            case 4:
                dialog = "Hey there! I wanna get high but I cant find my pipe, you help>;)";
                break;
            case 5:
                dialog = "Hey there! I know your dumb so give me your ip adress right neow!";
                break;
            case 6:
                dialog = "Hey there! I'm the main character so I want you to FINDING NEMO!!!!!!";
                break;
            case 7:
                dialog = "Hey there! I spent 69 days making a pepqueak house so I can cook the pepqueaks, you help me or me cook you.";
                break;
            case 8:
                dialog = "Hey there! I need you to find my red horn to bring kids into my basement";
                break;
            case 9:
                dialog = "Hey there! A magic guy loves making bunnys be gone and respawn, if you don't help me find it i will be gone and no respawn";
                break;
        
    }

}
