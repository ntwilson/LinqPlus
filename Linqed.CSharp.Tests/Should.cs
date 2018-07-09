using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Linqed.CSharpTests {
  public static class Should {
    public static void ShouldBe<T>(this T actual, T expected) {
      Assert.AreEqual(expected, actual);
    }

    public static void ShouldNotBe<T>(this T actual, T expected) {
      Assert.AreNotEqual(expected, actual);
    }

    public static void ShouldSatisfy<T>(this T a, Func<T, bool> condition) {
      Assert.IsTrue(condition(a));
    }
  }
}

