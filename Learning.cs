using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Here is your random number: " + GetRandomNumber());
        int firstNumber = GetRandomNumber();
        int secondNumber = GetRandomNumber();
        Debug.Log(firstNumber + " plus " + secondNumber + " is equal to " + AddTwoNumbers(firstNumber, secondNumber));  

        if(EvenChecker(GetRandomNumber()))
        {
            Debug.Log("Heads! We'll eat Pizza");
        } 
        else
        {
            Debug.Log("Tails! We'll eat Pasta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // return type is 'int', name is 'GetRandomNumber', no (parameters)
    int GetRandomNumber()
    {
        return Random.Range(0,100);
    }

    int AddTwoNumbers(int firstNum, int secondNum)
    {
        int sum = firstNum + secondNum;
        return sum;
    }

    bool EvenChecker(int num)
    {
        if(num % 2 == 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}
