using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int mp = 53;
    private int power = 25; 

   
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Magic()
    {

        if (this.mp <= 4)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");

        }


        
    }

    
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
       
        this.hp -= damage;
    }

}



public class Test : MonoBehaviour {

    // Use this for initialization

    


    void Start()
    {

        int[] array = new int[5];

        array[0] = 30;
        array[1] = 20;
        array[2] = 40;
        array[3] = 56;
        array[4] = 72;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array [i]);
        }

        for (int n = 4; n >= 0; n--)
        {
            Debug.Log(array [n]);
        }


        Boss lastboss = new Boss();

        
        lastboss.Attack();
        
        lastboss.Defence(3);

        lastboss.Magic();

        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }

        lastboss.Magic();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
