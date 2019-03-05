﻿using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem88Tests
{
	[TestFixture]
	public class DivideTests
	{
		[TestCase(5, 2)]
		[TestCase(12, 7)]
		[TestCase(1573, 22)]
		[TestCase(1756254, 4589)]
		public void TestDivide_ShouldReturnCorrectly(int divident, int divisor)
		{
			// Arrange
			var expected = divident / divisor;

			// Act
			var result = Solutions.Problem88.Solution.Divide(divident, divisor);

			// Assert
			Assert.AreEqual(expected, result);
		}
	}
}
