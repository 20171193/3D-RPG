using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************
 * <어댑터 패턴>
 * 호환하지 않는 두 객체를 호환시키는 방법
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
