using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Dice dicePrefab;
    public Button tossButton;

    public GameObject directionIndicator;
    public GameObject player;

    public int playerDiceCount = 3;

    // Start is called before the first frame update
    void Start()
    {
        tossButton.onClick.AddListener(TossDice);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TossDice() {
        for(int i = 0; i < playerDiceCount; i++) {
            Dice dice = Instantiate(dicePrefab, player.transform.position, Quaternion.identity);
            dice.Toss(directionIndicator.transform.position);
        }
    }
}
