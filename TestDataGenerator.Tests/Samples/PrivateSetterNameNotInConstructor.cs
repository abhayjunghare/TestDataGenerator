﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;
using System.Runtime.Serialization;


namespace TestDataGenerator.Tests.Samples
{
    
    
    
    public class PrivateSetterNameNotInConstructor : IAssertEquality
    {
       
       
        public int IntValue { get; private set; }

        public PrivateSetterNameNotInConstructor(int otherIntValue)
        {
            this.IntValue = otherIntValue;        
        }
        
        public static PrivateSetterNameNotInConstructor CreateInstance()
        {
            return new PrivateSetterNameNotInConstructor(10);
        }

        public void AssertEquality(object other)
        {
            Assert.IsNotNull(other);
            Assert.IsInstanceOfType<PrivateSetterNameNotInConstructor>(other);

            PrivateSetterNameNotInConstructor target = other as PrivateSetterNameNotInConstructor;

            Assert.AreEqual(this.IntValue, target.IntValue);
        }
    }
}
