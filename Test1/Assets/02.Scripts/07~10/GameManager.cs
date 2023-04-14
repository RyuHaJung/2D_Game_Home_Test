using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeLimit = 30f;
    private float timeElapsed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeLimit)
        {
            EndGame();
        }

    }
    public GameObject endGameButton;

    public void EndGame()
    {
        // ���� ���� ó��
        Time.timeScale = 0f;
        endGameButton.SetActive(true);
    }
    public void OnEndGameButtonClick()
    {
        // ��ư Ŭ�� ó��
        // ���� ���, ���� �޴��� ���ư��� ����� ������ �� �ֽ��ϴ�.
    }
}
