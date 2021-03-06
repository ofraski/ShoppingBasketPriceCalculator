﻿using NUnit.Framework;
using ShoppingBasket.Item;
using ShoppingBasket.Item.Exceptions;

namespace ShoppingBasket.Tests
{
    [TestFixture]
    public class ItemNameTests
    {
        [Test]
        public void NameRequired()
        {
            try
            {
                var name = new ItemName(string.Empty);
            }
            catch (BadItemNameException ex)
            {
                Assert.That(ex.Message.Contains("name is required"));
                return;
            }

            Assert.Fail("Expected exception not thrown");
        }
    }
}