using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    public void Deffence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        this.hp -= damage;
    }

    public void Magic()
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�@�c��mp��" + this.mp);
        }
        else
        {
            Debug.Log("mp������Ȃ����߁A���@���g���Ȃ�");
        }
    }
}
public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Deffence(3);
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
