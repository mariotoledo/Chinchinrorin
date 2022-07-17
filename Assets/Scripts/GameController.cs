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
        Dice dice = Instantiate(dicePrefab, player.transform.position, Quaternion.identity);
        Dice dice2 = Instantiate(dicePrefab, player.transform.position, Quaternion.identity);
        Dice dice3 = Instantiate(dicePrefab, player.transform.position, Quaternion.identity);
        Debug.Log(directionIndicator.transform.position);
        dice.Toss(directionIndicator.transform.position);
        dice2.Toss(directionIndicator.transform.position);
        dice3.Toss(directionIndicator.transform.position);
    }
}
