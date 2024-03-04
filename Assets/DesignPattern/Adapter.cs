using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************
 * <����� ����>
 * ȣȯ���� �ʴ� �� ��ü�� ȣȯ��Ű�� ���
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 *****************************************************/ 

namespace DesignPattern
{
    public class Customer
    {
        public Exchanger exchanger;
        public void Buy()
        {
            exchanger.Change();
        }
    }

    public class Store
    {
        private Exchanger exchanger;

        public void Sell()
        {
          
        }
    }

    public class Exchanger
    {
        public Customer customer;
        public Store store;

        public void Change()
        {

        }
    }
}
