﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;
using System.Runtime.Serialization;


namespace TestDataGenerator.Tests.Samples
{
    
    
    
    public class PrivateSetterNameNotInConstructorWithPrivateParameterlessConstructor : IAssertEquality
    {
       
       
        public int IntValue { get; private set; }

        private PrivateSetterNameNotInConstructorWithPrivateParameterlessConstructor() { }

        public PrivateSetterNameNotInConstructorWithPrivateParameterlessConstructor(int otherIntValue)
        {
            this.IntValue = otherIntValue;        
        }

        public static PrivateSetterNameNotInConstructorWithPrivateParameterlessConstructor CreateInstance()
        {
            return new PrivateSetterNameNotInConstructorWithPrivateParameterlessConstructor(10);
        }

        public void AssertEquality(object other)
        {
            Assert.IsNotNull(other);
            Assert.IsInstanceOfType<PrivateSetterNameNotInConstructorWithPrivateParameterlessConstructor>(other);

            PrivateSetterNameNotInConstructorWithPrivateParameterlessConstructor target = other as PrivateSetterNameNotInConstructorWithPrivateParameterlessConstructor;

            Assert.AreEqual(this.IntValue, target.IntValue);
        }
    }
}
