using NUnit.Framework;
using System;

namespace FinalTask_16._1.Tests
{
	[TestFixture]
	class CalculatorTests
	{
		[Test]
		public void AdditionalMustReturnCorrectValue()
		{
			Calculator calc = new Calculator();
			Assert.That(calc.Additional(220, 330) == 550);
		}

		[Test]
		public void SubtractionMustReturnCorrectValue()
		{
			Calculator calc = new Calculator();
			Assert.That(calc.Subtraction(330, 220) == 110);
		}

		[Test]
		public void MiltiplicationMustReturnCorrectValue()
		{
			Calculator calc = new Calculator();
			Assert.That(calc.Miltiplication(12, 34) == 408);
		}
		

		[Test]
		public void DivisionMustReturnCorrectValue()
		{
			Calculator calc = new Calculator();
			Assert.That(calc.Division(100, 10) == 10);
		}

		[Test]
		public void DivisionMustThrowException()
		{
			Calculator calc = new Calculator();
			Assert.Throws<DivideByZeroException>(() => calc.Division(30, 0));
		}
	}
}
