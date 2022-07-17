using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Dice dicePrefab;

    public Button throwButton;
    public Button selectIndicatorButton;

    public DirectionIndicator directionIndicator;
    public GameObject player;

    public int playerDiceCount = 3;

    GameStates gameState = GameStates.Idle;

    // Start is called before the first frame update
    void Start()
    {
        throwButton.onClick.AddListener(StartPlayerTurn);
        selectIndicatorButton.onClick.AddListener(SelectDirection);

        directionIndicator.gameObject.SetActive(false);
    }

    void StartPlayerTurn() {
        if(gameState == GameStates.Idle) {
            gameState = GameStates.SelectingDirection;

            directionIndicator.StartIndicator();

            throwButton.gameObject.SetActive(false);
            selectIndicatorButton.gameObject.SetActive(true);

            directionIndicator.gameObject.SetActive(true);
        }
    }

    void SelectDirection() {
        if(gameState == GameStates.SelectingDirection) {
            gameState = GameStates.Throwing;

            directionIndicator.StopIndicator();

            selectIndicatorButton.gameObject.SetActive(false);
            directionIndicator.gameObject.SetActive(false);

            ThrowDices();
        }
    }

    void ThrowDices() {
        if(gameState == GameStates.Throwing) {
            for(int i = 0; i < playerDiceCount; i++) {
                Dice dice = Instantiate(dicePrefab, player.transform.position, Quaternion.identity);
                dice.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                dice.gameObject.name = "dice" + i;
                dice.Toss(directionIndicator.transform.position);
            }
        }
    }
}
