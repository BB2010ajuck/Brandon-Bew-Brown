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
        collectibles = new string[] { "Tv", "coloured circles", "Floatie", "target", "Big pipe", "Ip adress", "Nemo", "Fly Animal House", "red PPhorn", "magical hat" };
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
            dialog = "You found my " + collectibles[clue] + ", me give you COEMS";
            end = true;
        }
        else
        {
            dialog = "No that's not my " + collectibles[clue] + " MAFAKA";
        }
    }

    public void coinsScattered()
    {
        begin = false;
    }

    public void searchDialog()
    {
        dialog = "Hi! Can you help me find my " + collectibles[clue] + "?";
    }

}
