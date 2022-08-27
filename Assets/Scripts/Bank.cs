using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    [SerializeField] int currentBalance;

    public int CurrentBalance{ get { return currentBalance; } }

    private void Awake() 
    {
        currentBalance = startingBalance;    
    }

    private void Update() 
    {
        LoseTheGame();
    }


    
    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
    }

    private void LoseTheGame()
    {
        if(currentBalance <= 0)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        }
    }
}
